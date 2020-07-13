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

begin
    insert into kategorije values( 1, 'Kora');
    insert into kategorije values( 2, 'Fil-1');
    insert into kategorije values( 3, 'Fil-2');
    insert into kategorije values( 4, 'Fil-3');
    insert into kategorije values( 5, 'Preliv');
    insert into kategorije values( 6, 'Glazura');
    insert into kategorije values( 7, 'Podloga');
    insert into kategorije values( 8, 'Slag');
    insert into kategorije values( 9, 'Dekoracija');
    insert into kategorije values(10, 'Ostalo');
end;

begin
    insert into pozicije values( 1, 'Vlasnik');
    insert into pozicije values( 2, 'Manager');
    insert into pozicije values( 3, 'Sef smene');
    insert into pozicije values( 4, 'Poslasticar');
    insert into pozicije values( 5, 'Konobar');
end;

begin
    insert into radnici values( 1, 'Maja', 'Jovanovic', '+381 6 209 4 152', 'Trg Slovode 3', '3312420052161', 1);
    insert into radnici values( 2, 'Milica', 'Nikolic', '+381 6 940 7 211', 'Trg Republike 6/1', '3839510776956', 2);
    insert into radnici values( 3, 'Jelena', 'Djordjevic', '+381 6 677 3 910', 'Cvijiceva 51', '5398026146574', 3);
    insert into radnici values( 4, 'Nina', 'Petrovic', '+381 6 399 1 778', 'Nusiceva 15', '1328386664885', 3);
    insert into radnici values( 5, 'Ljiljana', 'Markovic', '+381 6 933 7 147', 'Karadjordjeva 1/13', '2450689467806', 4);
    insert into radnici values( 6, 'Leposava', 'Stojanovic','+381 6 636 6 158','Karadjordjeva 57/14','6713108011825', 4);
    insert into radnici values( 7, 'Nikola', 'Ilic', '+381 6 629 9 060', 'Masarikova 16', '2617799351647', 4);
    insert into radnici values( 8, 'Luka', 'Stankovic', '+381 6 881 5 957', '5. Juli 7', '1452017451981', 5);
    insert into radnici values( 9, 'Zarko', 'Pavlovic', '+381 6 162 3 235', '16. Oktobar 4', '5195769463063', 5);
    insert into radnici values(10, 'Jovan', 'Simic', '+381 6 756 7 728', '1. Maj 18', '1812965201647', 5);
end;

begin
    insert into magacin values( 1, 'Plazma keks-biskvit', 3500, 1);
    insert into magacin values( 2, 'Plazma keks-mleveni', 2500, 1);
    insert into magacin values( 3, 'Kisela pavlaka', 4500, 1);
    insert into magacin values( 4, 'Secer u prahu', 5000, 1);
    insert into magacin values( 5, 'Mleko', 10000, 3);
    insert into magacin values( 6, 'Jagoda', 3000, 1);
    insert into magacin values( 7, 'Beli slag krem', 10000, 1);
    insert into magacin values( 8, 'Mineralna voda', 10000, 3);
    insert into magacin values( 9, 'Oreo keks', 1500, 1);
    insert into magacin values( 10, 'Puding od vanile', 200, 7);
    insert into magacin values( 11, 'Margarin', 1500, 1);
    insert into magacin values( 12, 'Maslac', 1500, 1);
    insert into magacin values( 13, 'Puding od cokolade', 200, 7);
    insert into magacin values( 14, 'Krem sir', 1000, 1);
    insert into magacin values( 15, 'Slatka pavlaka', 3000, 3);
    insert into magacin values( 16, 'Zelatin', 50, 7);
    insert into magacin values( 17, 'Cokolada za kuvanje', 3000, 1);
    insert into magacin values( 18, 'Milka noisiete', 2000, 1);
    insert into magacin values( 19, 'Nutela', 5000, 1);
    insert into magacin values( 20, 'Jaje', 200, 7);
    insert into magacin values( 21, 'Brasno', 5000, 1);
end;

begin
    insert into proizvodi values( 1, 'Plazma-jagoda torta', 2500, 3000, 'Napomena 1');
    insert into proizvodi values( 2, 'Oreo torta', 2500, 3500, 'Napomena 2');
    insert into proizvodi values( 3, 'Oreo-puding', 2000, 2500, 'Napomena 3');
    insert into proizvodi values( 4, 'Nutela torta', 2000, 4000, 'Napomena 4');
    insert into proizvodi values( 5, 'Jagoda torta', 2500, 3500, 'Napomena 5');
end;

begin
    insert into sastojci values( 1, 1, 1, 180, '');
    insert into sastojci values( 1, 5, 1, 150, '');
    insert into sastojci values( 1, 6, 2, 400, '');
    insert into sastojci values( 1, 7, 2, 200, '');
    insert into sastojci values( 1, 8, 2, 400, '');
    insert into sastojci values( 1, 2, 2, 250, '');
    insert into sastojci values( 1, 3, 3, 400, '');
    insert into sastojci values( 1, 4, 3, 100, '');
    insert into sastojci values( 1, 2, 3, 150, '');
    insert into sastojci values( 1, 7, 9, 150, '');
    insert into sastojci values( 1, 8, 9, 300, '');
    insert into sastojci values( 2, 9, 10, 500, '');
    insert into sastojci values( 2, 5, 10, 1000, '');
    insert into sastojci values( 2, 10, 10, 2, '');
    insert into sastojci values( 2, 11, 10, 450, '');
    insert into sastojci values( 4, 2, 1, 500, '');
    insert into sastojci values( 4, 11, 1, 80, '');
    insert into sastojci values( 4, 4, 1, 60, '');
    insert into sastojci values( 4, 5, 1, 100, '');
    insert into sastojci values( 4, 14, 2, 400, '');
    insert into sastojci values( 4, 15, 2, 500, '');
    insert into sastojci values( 4, 4, 2, 100, '');
    insert into sastojci values( 4, 19, 2, 400, '');
    insert into sastojci values( 4, 18, 5, 150, '');
    insert into sastojci values( 4, 15, 5, 150, '');
end;

begin
    insert into koraci values( 1, 1, 'Kora: Obru? kalupa za torte, vel. 26cm, oblo�iti providnom folijom i staviti ga na tacnu za torte. Plazma keks u komadu natopiti u mleku (pazite da ga ne natopite previ�e) i pore?ati unutar postavljenog kalupa, formiraju?i koru.');
    insert into koraci values( 1, 2, 'Vo?ni fil: Jagode sitno iseckati. Hladnu gaziranu vodu sipati u odgovaraju?u posudu, dodati beli �lag krem i ?vrsto umutiti. U umu?eni �lag dodati mlevenu plazmu i mikserom dobro sjediniti. Na kraju ubaciti iseckane jagode i ka�ikom ih sjediniti sa filom. Pripremljeni fil sipati preko kore i ka�ikom ga poravnati.');
    insert into koraci values( 1, 3, 'Fil sa pavlakom: Kiselu pavlaku izru?iti u odgovaraju?u posudu, dodati �e?er u prahu i ka�ikom sjediniti. Ubaciti mlevenu plazmi i ka�ikom je sjediniti sa pavlakom. Pripremljeni fil ka�ikom, malo po malo, naneti na fil sa vo?em i poravnati.');
    insert into koraci values( 1, 4, 'Dekoracija: Umutiti ?vrsto �lag krem sa gaziranom vodom. Umu?eni �lag naneti na fil sa pavlakom i dodatno ukrasiti sa jagodama.');
    insert into koraci values( 2, 1, 'U litar mleka skuvati dve kesice pudinga od vanile. I ostavite u stranu da se ohladi.');
    insert into koraci values( 2, 2, 'Dok se hladi puding. Istopiti 150g margarina. I umesajte sa 350g mlevenog Oreo keksa. Dodajete malo mleka i lepo sjediniti. U kalup za torte na dno ubaciti smesu od keksa i ravnomerno rasporediti.');
    insert into koraci values( 2, 3, 'Kada se puding ohladi, dodajete preostalog margarina i mlevenog Oreo keksa i izmiksirajte dok se sastojci ne sjedine. Prelite fil preko kore.');
    insert into koraci values( 2, 4, 'Za dekoraciju sam iskoristila �lag, preostali mleveni keks i ukras za torte u obliku srca. ');
    insert into koraci values( 4, 1, 'Plazmu i ?okoladu u prahu izme�ati. Dodati istopljen puter i mleko po potrebi. Smesa treba da bude takva da mogu kuglice da se naprave od nje.');
    insert into koraci values( 4, 2, 'Umutiti krem sir i �e?er u prahu. Posebno umutiti slatku pavlaku u ?vrst sneg. Sjediniti sve i dodati 400 g nutele malo omek�ane na pari. (da bi se lep�e umutio fil). Sipati preko kore');
    insert into koraci values( 4, 3, '150 ml slatke pavlake zagrejati do klju?anja. Skloniti sa vatre i ume�ati ?okoladu, me�ati sa se sve sjedini. Kada se malo ohladi sipati preko torte');
    insert into koraci values( 4, 4, 'Ukrasiti po �elji. Mozete okolo staviti mrvljeni le�nik, gore malo �laga i le�nika');
end;

begin
    insert into pravljenje values( 3, 4, 1, '01-JUN-2020', 'Napomena 1');
    insert into pravljenje values( 3, 4, 2, '01-JUN-2020', 'Napomena 2');
    insert into pravljenje values( 6, 1, 1, '01-JUN-2020', 'Napomena 3');
    insert into pravljenje values( 3, 2, 1, '01-JUN-2020', 'Napomena 4');
    insert into pravljenje values( 6, 1, 1, '05-JUN-2020', 'Napomena 5');
    insert into pravljenje values( 6, 1, 2, '05-JUN-2020', 'Napomena 6');
    insert into pravljenje values( 3, 4, 1, '05-JUN-2020', 'Napomena 7');
    insert into pravljenje values( 7, 2, 1, '05-JUN-2020', 'Napomena 8');
    insert into pravljenje values( 3, 4, 2, '05-JUN-2020', 'Napomena 9');
    insert into pravljenje values( 7, 2, 2, '05-JUN-2020', 'Napomena 10');
end;

select sysdate from dual
