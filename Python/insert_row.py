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
val = ("Vinícius Leal Galantine", "1999-08-20 06:30:00.000000", now)
mycursor.execute(sql, val)

mydb.commit()

print(mycursor.rowcount, "record inserted.")