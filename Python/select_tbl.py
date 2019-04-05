# -*- coding: utf-8 -*-
import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  passwd="",
  database="learning"
)

mycursor = mydb.cursor()

mycursor.execute("select * from clients")

myresult = mycursor.fetchall()

for x in myresult:
  print(x)