# System Requirement Specification - Asteroid information center
### Version:
0.1
### Date created:
3.10. 2022
### Author:
Ron Studený 4.C SSPŠaG
### Contact:
studeny.ro.2019@skola.ssps.cz

ronstudeny@gmail.com

### Summary:
## 1.0 Introduction
### 1.1 Document Purpose
Document serves to give the reader a basic idea behind this application as well as to provide specific information about the features and requirements of the application.
### 1.2 Conventions & Explenations
Keywords that need an extra explenation and/or specification are highlighted in **bold** text and are specified below:
**NASA's Asteroids - NeoWs API** - A publicly available API provided by NASA for the purpose
**Xamarin Forms** -

### 1.3 Document Dedicated To
This document is dedicated to my app development teacher Ing. Pavel Švec or to anyone unfortunate enough to have stumbled upon this on my profile.
### 1.4 Disclaimer
This document serves only as a demonstration and may contain inaccurate information.

## 2.0 Overall Description
### 2.1 About Software 
The application will be a mobile app. It's purpose being to display simplified information about asteroids orbiting the Earth. This information will be provided by tha **NASA's Asteroids - NeoWs API** (further just **NeoWs API**). Main focus of the app is to differentiate between potentionaly dangerous and non-dangerous asteroids aswell as to provide some basic information about them and to put that information into perspective. 
### 2.2 Targeted User Groups
Software is designed for an average user. No special knowledge is required to operate the app, all that is needed is the user's interest. 
### 2.3 Software Enviromnent
The app is developed in **Xamarin Forms** using **Visual Studio** and, as already mentioned, uses **NeoWs API** to get the necesseary information.   
### 2.4 User Interface
In the first version the **UI** will be as simplistic as possible, with the application only offering a button to display asteroids in orbit around Earth. Basic navigation system is always available for future convinience and easier implementation.

## 3.0 Feature Overview
### 3.1 Main Menu
As mentioned above, in this version the main menu only offers one option, that is to show all the asteroids orbiting earth as provided by the **NeoWs API**.
### 3.2 Asteroid Page
Displays all asteroids orbiting earth sorted by wheter or not they are pottentialy dangerous or not. Each can be tapped to display additional information.
### 3.3 Specific Asteroid Overview
When a desired asteroid is tapped a page with additional information is displayed, showing a list of transpired and predicted close approaches aswell as information about each of these aproaches.

## 4.0 Other Specifications
### 4.1 Supported OS
The application is developed with use intended only for Android mobile phones.
### 4.2 User Orientation
With the release of the first version a user documentation will be published, with the specifics on how to operate the app.
### 4.3 Software Documentation
Functional specification aswell as detailed software documentation will be provided with the release of the first version.
