# Functional Specification - Asteroid information center

### Version:
0.1
### Date created:
10.10. 2022
### Author:
Ron Studený 4.C SSPŠaG
### Contact:
studeny.ro.2019@skola.ssps.cz

ronstudeny@gmail.com
## 1.0 Introduction
### 1.1 Document Purpose
This document serves to provide a detailed overview of all functional aspects of the application.
### 1.2 Conventions & Explenations
Keywords that need an extra explenation and/or specification are highlighted in **bold** text and are specified below:

**NASA's Asteroids - NeoWs API** - A publicly available API provided by NASA for the purpose of obtaining information about asteroids. Reffered to as "**NeoWs API**" in the document

### 1.3 Targeted End User Group
The app is targeted at an average mobile phone user, who may be interested in space related topics, including but not limited to asteroids, which is the main focus of this app.
## 2.0 Scenarios
### 2.1 User Standpoint
The app serves to give an insight into the asteroids orbiting the Earth and tries to put information about them into a perspective.
### 2.2 User Categorie
Possible user categories and groups may include but are not limited to: students, teachers, space enthusiasts, etc.
### 2.3 Project Scope
The project includes basic overview of asteroids orbiting various planets of our solar system with the most prominent one being Earth. Each asteroid may be tapped to reveal additional information provided by the **NeoWs API**.
### 2.4 Unimportant Features
The project will not include a search engine, to search for a specific asteroid, as it wouldn't provide much convinience to the user to begin with.
## 3.0 App Architecture
### 3.1 Application Flow
The user is greeted by a main menu with the selection of planets in our solar system. Upon taping the desired planet, a list of asteroids orbiting the said planet is displayed, with the information provided by a request from the **NeoWs API** or data from the last succesful request, in the event of failure.
![This is an image](https://cdn.discordapp.com/attachments/816343472776806452/1031654164410945647/Hlavni_menu.png)
### 3.2 Primary Sorting
The first sorting phase the aplication goes through is the planets. Each planet, with available information about them is displayed in the first interaction the user goes through.
### 3.3 Secondary Sorting
Upon Selecting a planet a list of orbiting ateroids is displayed and is sorted by whether or not they are potentially dangerous.
![This is an image](https://media.discordapp.net/attachments/816343472776806452/1031658067210805332/Specific_planet.png)
### 3.4 Specific Asteroid Overview
Each Asteroid can be tapped to reveal additional information about the specific asteroid, such as: transpired and predicted close approaches, estimated mass, estimated magnitude etc.
![This is an image](https://cdn.discordapp.com/attachments/816343472776806452/1031667849078522028/Specific_asteroid.png)
### 3.5 Data Handling
Requested data is saved in the form of a .json file and with each new request is overwirtten. This is done, so that if the internet isn't available or the request fails for whatever reason, the app still has somewhere to pull data from.
![This is an image](https://cdn.discordapp.com/attachments/816343472776806452/1031672116640239647/flow_chart.png)
