
CREATE TABLE people
(
  id int,
  FiO text,
  Data_born text,
  Status text
);
insert into people (id, FIO, Data_born, Status)
values
  (1, 'Иванов И. И.', '2/12/1990', 'женат'),
  (2, 'Иванов И. И.', '9/18/2001', 'холост'),
  (3, 'Петров П. П.', '4/23/1983', 'женат'),
  (4, 'Васильев В. В.', '5/21/1998', 'холост'),
  (25, 'Кузьмин К.К.', '5/21/2020', 'холост');
select * from people;

select 'NEXt_Table';

CREATE TABLE adress_people
(
  chey_adres int,
  adres text,
  Comment text
);
insert into adress_people (chey_adres, adres, Comment)
values
  (1, 'Можга', 'Место рождения'),
  (1, 'Казань', 'По прописке'),
  (1, 'Москва', 'Рабочий'),
  (2, 'Санкт-Петербург', 'По прописке'),
  (3, 'Москва', 'По прописке'),
  (4, 'Белгород', 'По прописке'),
  (5, 'Уфа', 'По прописке'),
  (6, 'Сочи', 'По прописке'),
  (7, 'Киров', 'Рабочий'),
  (8, 'Владивосток', 'Место рождения'),
  (9, 'Рязань', 'Рабочий'),
  (10, 'Хабаровск', 'Место рождения');
select * from adress_people;

select '1. INNER JOIN Люди, Адреса ON id = Чей адрес';
select * from people INNER JOIN adress_people where  id = chey_adres;

select '2. LEFT JOIN Люди, Адреса ON id = Чей адрес';
select * from people LEFT JOIN adress_people ON id = chey_adres;

select '3. RIGHT JOIN Люди, Адреса ON id = Чей адрес';
select * from people RIGHT JOIN adress_people ON id = chey_adres;

select '4. FULL JOIN Люди, Адреса ON id = Чей адрес';
select * from people FULL JOIN adress_people ON id = chey_adres;

-- Дополнительное задание. Что будет результатом выборки:

SELECT 'Additional task';

SELECT FIO, adres, Comment 
FROM people RIGHT JOIN adress_people ON id = chey_adres;



