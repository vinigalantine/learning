# -*- coding: utf-8 -*-

import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  passwd="",
  database="learning"
)

mycursor = mydb.cursor()

mycursor.execute("create table clients (id int not null auto_increment, name varchar(80) NOT NULL, birth_date date not null, created_at date not null, updated_at date, deleted_at date, primary key (id))")

mycursor.execute("show tables")

for x in mycursor:
  print(x)