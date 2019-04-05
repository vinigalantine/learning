# -*- coding: utf-8 -*-

import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  passwd=""
)

mycursor = mydb.cursor()

prosseguir = input("Deseja criar um novo banco?(S para \"SIM\" | N para \"NÃO\") ").lower()

if (prosseguir == "s"):

	db_name = ""

	while db_name != "exit":
		
		db_name = input("Forneça o nome do banco (Digite \"exit\"): ").lower()

		if db_name == "exit":
			break
			
		mycursor.execute("create database "+db_name+" character set utf8mb4 collate utf8mb4_unicode_ci")

		print("Banco criado, verifique na lista abaixo:")
		mycursor.execute("show databases")

		for x in mycursor:
			print(x)
	else  :
		print("Finalizado!")

else :
	print("Finalizado!")