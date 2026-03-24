/*
Main entry file for EventSphere
This file initializes the correct controller
based on the current page.
*/

import { loadEvents, handleAddEvent } from "./controllers/eventController.js"

import {
loadEventDetails,
handleRegistration
} from "./controllers/registrationController.js"

document.addEventListener("DOMContentLoaded", () => {

const page = window.location.pathname



/* =========================
   Home Page (index.html)
========================= */

// if(page.includes("index.html") || page === "/"){

//     loadEvents()

// }

if(page.endsWith("index.html") || page === "/" || page === "/index.html"){
    loadEvents()
}



/* =========================
   Add Event Page
========================= */

if(page.includes("add-event.html")){

    const form = document.getElementById("eventForm")

    if(form){

        form.addEventListener("submit",(e)=>{

            e.preventDefault()

            handleAddEvent(form)

        })

    }

}



/* =========================
   Registration Page
========================= */

if(page.includes("register.html")){

    loadEventDetails()

    const form = document.getElementById("registrationForm")

    if(form){

        form.addEventListener("submit",(e)=>{

            e.preventDefault()

            handleRegistration(form)

        })

    }

}

})
