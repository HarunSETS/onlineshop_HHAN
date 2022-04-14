
drop table if exists stavke_narudzbenica;
drop table if exists narudzbenice;
drop table if exists skladiste;
drop table if exists artikli;
drop table if exists kupci;
drop table if exists tipovi_korisnika;


create table tipovi_korisnika (
  tip_korisnika_id varchar(3) not null,
  naziv varchar(100) not null,
  pozdravna_poruka varchar(300),
  primary key pk_tipovi_korisnika (tip_korisnika_id)
);

insert into tipovi_korisnika(tip_korisnika_id, naziv, pozdravna_poruka)  
values ('ADM', 'Administrator', 'Zelimo vam ugodno administriranje aplikacije. (Mozete administrirati kupce i artikle, a mozete i pregledati narudzbe svih kupaca ili ih cak i obrisati.)');

insert into tipovi_korisnika(tip_korisnika_id, naziv, pozdravna_poruka)  
values ('KUP', 'Kupac', 'zelimo vam ugodnu kupovinu. (Mozete kreirati novu narudzbu ili pregledati svoje ranije narudzbe.)');

insert into tipovi_korisnika(tip_korisnika_id, naziv, pozdravna_poruka)  
values ('REV', 'Racunovoda', 'Uloga trenutno nije podrzana!!!');

create table kupci (
  kupac_id int not null auto_increment,
  user varchar(30) not null,
  pass varchar(30) not null,
  tip_korisnika_id varchar(3) not null default 'KUP',
  ime varchar(50) not null,
  prezime varchar(50) not null,
  adresa varchar(200) not null,
  grad varchar(50) not null,
  telefon varchar(30) not null,
  primary key pk_kupci (kupac_id),
  constraint uk_kupci unique (user),
  constraint fk_kupci_tipovi_korisnika foreign key (tip_korisnika_id) references tipovi_korisnika (tip_korisnika_id)
);

insert into kupci(kupac_id, user, pass, tip_korisnika_id, ime, prezime, adresa, grad, telefon)  
values (1, 'harun.tabak', 'harun', 'ADM', 'Harun', 'Tabak', 'Milana preloga 13', 'Sarajevo', '061298699');

insert into kupci(kupac_id, user, pass, tip_korisnika_id, ime, prezime, adresa, grad, telefon)  
values (2, 'hamza.dedovic', 'hamza', 'ADM', 'Hamza', 'Dedovic', 'Binjezevo 9', 'Sarajevo', '0603066779');

insert into kupci(kupac_id, user, pass, tip_korisnika_id, ime, prezime, adresa, grad, telefon)  
values (3, 'adi.drakovac', 'adi', 'KUP', 'Adi', 'Drakovac', 'Sulje Jahica 81', 'Sarajevo', '062009537');

insert into kupci(kupac_id, user, pass, tip_korisnika_id, ime, prezime, adresa, grad, telefon)  
values (4, 'nedim.redzovic', 'nedim', 'KUP', 'Nedim', 'Redzovic', 'Josipa Broza', 'Hrasnica', '069696696');

insert into kupci(kupac_id, user, pass, tip_korisnika_id, ime, prezime, adresa, grad, telefon)  
values (5, 'mujo.mujic', 'mujo', 'REV', 'Mujo', 'Mujic', 'Branka Copica 57', 'Mostar', '063546879');

insert into kupci(kupac_id, user, pass, tip_korisnika_id, ime, prezime, adresa, grad, telefon)  
values (6, 'adnan.delic', 'adnan', 'ADM', 'Adnan', 'Delic', 'Safeta Zajke 10', 'Mostar', '061234567');


create table narudzbenice (
  narudzbenica_id int not null auto_increment,
  kupac_id int not null,
  datum_narudzbe datetime not null,
  primary key pk_narudzbenice (narudzbenica_id),
  constraint fk_narudzbe_kupci foreign key (kupac_id) references kupci (kupac_id)
);

insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (1, 3, date_sub(now(), interval 25 hour));  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (2, 3, date_sub(now(), interval 24 hour));  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (3, 3, date_sub(now(), interval 23 hour));  
  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (4, 4, date_sub(now(), interval 12 hour));  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (5, 4, date_sub(now(), interval 11 hour));  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (6, 4, now());  

insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (7, 6, date_sub(now(), interval 3 hour));  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (8, 6, date_sub(now(), interval 2 hour));  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (9, 6, date_sub(now(), interval 1 hour));  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (10, 6, now());  

create table artikli (
  artikal_id int not null auto_increment,
  bar_kod varchar(20) not null,
  naziv_artikla varchar(100) not null,
  vrsta_artikla varchar(100) not null,
  cijena double not null,
  primary key pk_artikli (artikal_id),
  constraint uk_artikli unique (bar_kod)
);

insert into artikli(artikal_id, bar_kod, naziv_artikla, vrsta_artikla, cijena) values (1, '00001', 'Xiaomi Mi 8', 'Mobitel', 750.80);
insert into artikli(artikal_id, bar_kod, naziv_artikla, vrsta_artikla, cijena) values (2, '00002', 'Galaxy Note 10', 'Mobitel', 1020.00);
insert into artikli(artikal_id, bar_kod, naziv_artikla, vrsta_artikla, cijena) values (3, '00003', 'Keabord proffesional 12R', 'Tastatura', 103.50);
insert into artikli(artikal_id, bar_kod, naziv_artikla, vrsta_artikla, cijena) values (4, '00004', 'Mouse optical Vox', 'Mis', 9.99);
insert into artikli(artikal_id, bar_kod, naziv_artikla, vrsta_artikla, cijena) values (5, '00005', 'Kingstone USB Stick 8 GB', 'USB', 10.00);
insert into artikli(artikal_id, bar_kod, naziv_artikla, vrsta_artikla, cijena) values (6, '00006', 'Kingstone USB Stick 16 GB', 'USB', 14.50);
insert into artikli(artikal_id, bar_kod, naziv_artikla, vrsta_artikla, cijena) values (7, '00007', 'Kingstone USB Stick 32 GB', 'USB', 20.99);
insert into artikli(artikal_id, bar_kod, naziv_artikla, vrsta_artikla, cijena) values (8, '00008', 'Xotas Joystick T210', 'Joystick', 319.99);
insert into artikli(artikal_id, bar_kod, naziv_artikla, vrsta_artikla, cijena) values (9, '00009', 'Flight Simulator 2020', 'PC Game', 250.00);
insert into artikli(artikal_id, bar_kod, naziv_artikla, vrsta_artikla, cijena) values (10, '00010', 'Car Mechanic Simulator', 'PC Game', 90.20);




create table skladiste (
  id int not null auto_increment,
  artikal_id int not null,
  kolicina_stanje int not null,
  primary key pk_skladiste (id),
  constraint fk_skladiste_artikli foreign key (artikal_id) references artikli (artikal_id)
);

insert into skladiste(artikal_id, kolicina_stanje) values (1, 10);
insert into skladiste(artikal_id, kolicina_stanje) values (2, 10);
insert into skladiste(artikal_id, kolicina_stanje) values (3, 50);
insert into skladiste(artikal_id, kolicina_stanje) values (4, 20);
insert into skladiste(artikal_id, kolicina_stanje) values (5, 80);
insert into skladiste(artikal_id, kolicina_stanje) values (6, 80);
insert into skladiste(artikal_id, kolicina_stanje) values (7, 440);
insert into skladiste(artikal_id, kolicina_stanje) values (8, 34);
insert into skladiste(artikal_id, kolicina_stanje) values (9, 55);
insert into skladiste(artikal_id, kolicina_stanje) values (10, 70);



create table stavke_narudzbenica (
  stavka_id int not null auto_increment,
  narudzbenica_id int not null,
  artikal_id int not null,
  kolicina int not null,
  primary key pk_stavke_narudzbenica (stavka_id),
  constraint uk_stavke_narudzbenica unique (narudzbenica_id, artikal_id),
  constraint fk_stavke_narudzbenice foreign key (narudzbenica_id) references narudzbenice (narudzbenica_id),
  constraint fk_stavke_artikli foreign key (artikal_id) references artikli (artikal_id)
);

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (1, 3, 5);

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (2, 2, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (2, 5, 2);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (2, 6, 3);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (2, 7, 1);

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (3, 1, 2);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (3, 4, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (3, 9, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (3, 10, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (3, 8, 2);




insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (4, 1, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (4, 2, 3);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (4, 3, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (4, 4, 2);

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (5, 1, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (5, 2, 2);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (5, 4, 3);


insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (6, 3, 3);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (6, 4, 2);




insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (7, 3, 3);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (7, 4, 2);

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (8, 4, 2);

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (9, 1, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (9, 2, 2);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (9, 4, 3);

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (10, 1, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (10, 2, 3);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (10, 3, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (10, 4, 2);

