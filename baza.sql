
drop table if exists stavke_narudzbenica;
drop table if exists narudzbenice;
drop table if exists artikli;
drop table if exists skladiste;
drop table if exists kupci;
drop table if exists tipovi_korisnika;


create table tipovi_korisnika (
  tip_korisnika_id varchar(3) not null,
  naziv varchar(100) not null,
  pozdravna_poruka varchar(300),
  primary key pk_tipovi_korisnika (tip_korisnika_id)
);

insert into tipovi_korisnika(tip_korisnika_id, naziv, pozdravna_poruka)  
values ('ADM', 'Administrator', 'Želimo vam ugodno administriranje aplikacije. (Možete administrirati kupce i artikle, a možete i pregledati narudžbe svih kupaca ili ih čak i obrisati.)');

insert into tipovi_korisnika(tip_korisnika_id, naziv, pozdravna_poruka)  
values ('KUP', 'Kupac', 'Želimo vam ugodnu kupovinu. (Možete kreirati novu narudžbu ili pregledati svoje ranije narudžbe.)');

insert into tipovi_korisnika(tip_korisnika_id, naziv, pozdravna_poruka)  
values ('REV', 'Računovođa', 'Uloga trenutno nije podržana!!!');

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
values (3, 'adi.drakovac', 'adi', 'KUP', 'Adi', 'Drakovac', 'Sulje Jahića 81', 'Sarajevo', '062009537');

insert into kupci(kupac_id, user, pass, tip_korisnika_id, ime, prezime, adresa, grad, telefon)  
values (4, 'nedim.redzovic', 'nedim', 'KUP', 'Nedim', 'Redžović', 'Josipa Broza', 'Hrasnica', '069696696');

insert into kupci(kupac_id, user, pass, tip_korisnika_id, ime, prezime, adresa, grad, telefon)  
values (5, 'mujo.mujic', 'mujo', 'REV', 'Mujo', 'Mujić', 'Branka Čopića 57', 'Mostar', '063546879');

insert into kupci(kupac_id, user, pass, tip_korisnika_id, ime, prezime, adresa, grad, telefon)  
values (6, 'adnan.delic', 'adnan', 'ADM', 'Adnan', 'Delić', 'Safeta Zajke 10', 'Mostar', '065456456');


create table narudzbenice (
  narudzbenica_id int not null auto_increment,
  kupac_id int not null,
  datum_narudzbe datetime not null,
  primary key pk_narudzbenice (narudzbenica_id),
  constraint fk_narudzbe_kupci foreign key (kupac_id) references kupci (kupac_id)
);

insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (1, 3, date_sub(now(), interval 5 hour));  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (2, 3, date_sub(now(), interval 4 hour));  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (3, 3, date_sub(now(), interval 3 hour));  
  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (4, 4, date_sub(now(), interval 2 hour));  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (5, 4, date_sub(now(), interval 1 hour));  
insert into narudzbenice(narudzbenica_id, kupac_id, datum_narudzbe) values (6, 4, now());  



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
insert into artikli(artikal_id, bar_kod, naziv_artikla, vrsta_artikla, cijena) values (4, '00004', 'Mouse optical Vox', 'Miš', 9.99);




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

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (1, 1, 2);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (1, 4, 1);

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (2, 2, 1);

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (3, 3, 5);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (3, 4, 2);

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (4, 1, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (4, 2, 3);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (4, 3, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (4, 4, 2);

insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (5, 1, 1);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (5, 2, 2);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (5, 4, 3);


insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (6, 3, 3);
insert into stavke_narudzbenica(narudzbenica_id, artikal_id, kolicina) values (6, 4, 2);
