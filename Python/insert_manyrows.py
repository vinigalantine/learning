# -*- coding: utf-8 -*-
import mysql.connector
import datetime

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  passwd="",
  database="learning"
)

now = datetime.datetime.now()

mycursor = mydb.cursor()

sql = "insert into clients (name, birth_date, created_at) VALUES (%s, %s, %s)"
val = [
  ("Teste T.", "2003-12-26 06:30:00.000000", now),
  ("Teste T. Teste", "1922-02-18 06:30:00.000000", now),
  ("Terezinha Corrêa Leal", "1932-08-29 06:30:00.000000", now)
]

mycursor.executemany(sql, val)

mydb.commit()

print(mycursor.rowcount, "was inserted.")