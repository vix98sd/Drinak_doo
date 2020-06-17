create table jedinice_mere(
    ID_JM number(3,0) primary key,
    Naziv varchar2(10) not null
);

create table kategorije(
    ID_Kategorija number(3,0) primary key,
    Naziv varchar2(10) not null
);

create table pozicije(
    ID_Pozicija number(3,0) primary key,
    Naziv varchar2(20) not null
);

create table proizvodi(
    ID_Proizvod number(3,0) primary key,
    Naziv varchar2(20) not null,
    Tezina number(6,0) not null,
    Cena number(6,2) not null,
    Napomena varchar2(50)
);

create table radnici(
    ID_Radnik number(3,0) primary key,
    Ime varchar2(20) not null,
    Prezime varchar2(20) not null,
    Telefon varchar2(20) not null,
    Adresa varchar2(20) not null,
    JMBG varchar2(13) not null,
    ID_Pozicija number(3,0),
    constraint radnici_poz_fk foreign key(ID_Pozicija) references pozicije(ID_Pozicija)
);

create table magacin(
    ID_Robe number(3,0) primary key,
    Naziv varchar2(20) not null,
    Kolicina number(6,0) not null,
    ID_JM number(3,0),
    constraint magacin_jm_fk foreign key(ID_JM) references jedinice_mere(ID_JM)  
);

create table koraci(
    ID_Proizvod number(3,0),
    Redni_broj number(3,0),
    Opis varchar2(500) not null,
    constraint koraci_proiz_fk foreign key(ID_Proizvod) references proizvodi(ID_Proizvod),
    constraint koraci_pk primary key(ID_Proizvod, Redni_broj)
);

create table sastojci(
    ID_Proizvod number(3,0),
    ID_Robe number(3,0),
    ID_Kategorija number(3,0),
    Kolicina number(5,0) not null,
    Naziv_kategorije varchar2(10) not null,
    constraint sastojci_proiz_fk foreign key(ID_Proizvod) references proizvodi(ID_Proizvod),
    constraint sastojci_roba_fk foreign key(ID_Robe) references magacin(ID_Robe),
    constraint sastojci_kateg_fk foreign key(ID_Kategorija) references kategorije(ID_Kategorija),
    constraint sastojci_pk primary key(ID_Proizvod, ID_Robe, ID_Kategorija)
);

create table pravljenje(
    ID_Radnik number(3,0),
    ID_Proizvod number(3,0),
    Rbr_pravljenja number(3,0),
    Datum date,
    Napomena varchar2(50),
    constraint pravljenje_radnik_fk foreign key(ID_Radnik) references radnici(ID_Radnik),
    constraint pravljenje_proiz_fk foreign key(ID_Proizvod) references proizvodi(ID_Proizvod),
    constraint pravljenje_pk primary key(ID_Radnik, ID_Proizvod, Rbr_Pravljenja, Datum)
);

create or replace trigger naziv_kategorije_update
after update on kategorije
for each row
declare
    pragma autonomous_transaction;
    t_naziv varchar2(10);
begin
    execute immediate 'alter trigger sastojci_dn_in_up disable';
    execute immediate 'alter trigger sastojci_dn_update disable';
    t_naziv := :new.Naziv;
    update sastojci
    set sastojci.Naziv_kategorije = t_naziv
    where sastojci.ID_Kategorija = :new.ID_Kategorija;
    execute immediate 'alter trigger sastojci_dn_update enable';
    execute immediate 'alter trigger sastojci_dn_in_up enable';
end;

create or replace trigger sastojci_dn_in_up
before insert or update on sastojci
for each row
declare
    t_naziv varchar2(10);
begin
    select naziv into t_naziv
    from kategorije
    where kategorije.ID_Kategorija = :new.ID_Kategorija;
    :new.Naziv_kategorije := t_naziv;
end;

create or replace trigger sastojci_dn_update
before update of naziv_kategorije on sastojci
for each row
begin
    raise_application_error(
        num => -20002,
        msg => 'Ne mozete direktno menjati naziv kategorije!'
    );
end;

create or replace procedure get_worker_level
(p_id_radnik in pravljenje.id_radnik%TYPE, p_level out varchar2)
is
v_broj_napravljenih number(5);
begin
    select count(id_proizvod) into v_broj_napravljenih
    from pravljenje
    where id_radnik = p_id_radnik
    group by id_radnik; 

    if (v_broj_napravljenih < 10)
    then p_level := 'O';
    elsif (v_broj_napravljenih < 101)
    then p_level := 'I';
    elsif (v_broj_napravljenih > 100) and (v_broj_napravljenih < 501)
    then p_level := 'II';
    elsif (v_broj_napravljenih > 500)
    then p_level := 'III';
    end if;

    p_level := 'Radnik je ' || p_level || ' stepen'; 

    exception
        when NO_DATA_FOUND then
        begin
            p_level := 'Birani radnik nije napravio ni jedan proizvod!';
        end;
end;

create or replace function get_worker_most (p_id_radnik number)
return varchar2
is
    p_id number(3);
    maxi number(5);
    p_naziv varchar2(20);
begin
    select id_proizvod, count(id_proizvod) as "br_proizvoda"
    into p_id, maxi
    from pravljenje
    where id_radnik = p_id_radnik
    group by id_proizvod
    having count(id_proizvod) = (
        select max(count(id_proizvod)) as "max"
        from pravljenje
        where id_radnik = p_id_radnik
        group by id_proizvod
        );
 
   select naziv into p_naziv
   from proizvodi
   where id_proizvod = p_id;
   
   if maxi < 10
   then return 'Ovaj radnik je pocetnik, najvise pravio proizvod po imenu: ' || p_naziv || '.';
   elsif maxi < 50
   then return 'Ovaj radnik je noviji radnik, najvise je pravio proizvod po imenu: ' || p_naziv || '.';
   elsif maxi >= 50
   then return 'Ovaj radnik je majstor za proizvod po imenu: ' || p_naziv || '.';
   end if;
   
   exception
   when NO_DATA_FOUND
   then return 'Izabrani radnik nije majstor ni za jedan proizvod!';
   when OTHERS
   then return SQLERRM;
end;

begin
insert into jedinice_mere values(1, 'gr');    -- 0.001 kg
insert into jedinice_mere values(2, 'kg');
insert into jedinice_mere values(3, 'ml');    -- 0.001 l
insert into jedinice_mere values(4, 'cl');    -- 0.01  l
insert into jedinice_mere values(5, 'dl');    -- 0.1   l
insert into jedinice_mere values(6, 'l');
insert into jedinice_mere values(7, 'kom');
insert into jedinice_mere values(8, 'kutija');
end;

