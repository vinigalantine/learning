# An example of automatizated login
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

usernameStr = 'username'
passwordStr = 'password'

browser = webdriver.Chrome()
browser.get(('url'))

username = browser.find_element_by_id('inputEmail')
username.send_keys(usernameStr)

password = browser.find_element_by_id('inputPassword')
password.send_keys(passwordStr)

signInButton = browser.find_element_by_xpath("//button[@type='submit']")
signInButton.click()