# -*- coding: utf-8 -*-

import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  passwd=""
)

mycursor = mydb.cursor()

schema_name = input('Nome do BD: ')

mycursor.execute("drop schema "+schema_name)

for x in mycursor:
  print(x)