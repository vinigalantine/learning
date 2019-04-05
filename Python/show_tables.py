# -*- coding: utf-8 -*-

import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  passwd="",
  database="learning"
)

mycursor = mydb.cursor()

mycursor.execute("show tables")

for x in mycursor:
  print(x)