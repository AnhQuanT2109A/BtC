create table if not exists books (
    bookid int(11) not null auto_increment,
    authorid int(11) not null,
    title varchar(55) not null,
    ISBN varchar(25) not null,
    pub_year smallint(6) not null,
    available tinyint(4) not null,
    primary key(bookid)
    ) engine=InnoDB default charset=utf8 auto_increment=4 ;

insert into books (bookid, authorid, title, ISBN, pub_year, avaiable) values
(1, 0, 'De Men Phuong Luu Ky', '21E04', 1941, 1),
(2, 12, 'Truyen Kieu', 'UY890', 1805, 0),
(3, 2, 'Song', 'XQ09', 1967, 1),
(4, 13,'Vo Chong A Phu', 'TH52', 1952, 1),
(5, 43,'Doremon', 'F178', 1979, 2);