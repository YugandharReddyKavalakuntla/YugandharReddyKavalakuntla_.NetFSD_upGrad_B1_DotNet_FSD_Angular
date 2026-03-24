// import Registration from "../models/Registration.js"

// import {
// getEventById,
// updateEvent,
// createRegistration
// } from "../services/apiService.js"

// import {
// showError,
// showSuccess,
// getQueryParam
// } from "../utils/helpers.js"

// import {
// isRequired,
// isValidEmail,
// isValidPhone
// } from "../utils/validation.js"

// /* ===============================
// Load Event Details
// ================================ */

// export const loadEventDetails = async () => {


// try {

//     const eventId = getQueryParam("eventId")

//     if (!eventId) {
//         showError("Invalid event ID")
//         return
//     }

//     const event = await getEventById(eventId)

//     const container = document.getElementById("eventDetails")

//     if (!container) return

//     container.innerHTML = `
//         <h2>${event.title}</h2>
//         <p>${event.description}</p>
//         <p><b>Date:</b> ${event.date}</p>
//         <p><b>Location:</b> ${event.location}</p>
//         <p><b>Available Seats:</b> ${event.availableSeats}</p>
//     `

// } catch (error) {

//     showError("Failed to load event details")

// }


// }

// /* ===============================
// Handle Registration
// ================================ */

// export const handleRegistration = async (form) => {


// try {

//     const eventId = getQueryParam("eventId")

//     const name = form.participantName.value
//     const email = form.email.value
//     const phone = form.phone.value


//     /* -------- Validation -------- */

//     if (!isRequired(name)) {
//         return showError("Name is required")
//     }

//     if (!isValidEmail(email)) {
//         return showError("Invalid email format")
//     }

//     if (!isValidPhone(phone)) {
//         return showError("Phone must be 10 digits")
//     }


//     /* -------- Fetch Event -------- */

//     const event = await getEventById(eventId)

//     if (event.availableSeats <= 0) {
//         return showError("No seats available for this event")
//     }


//     /* -------- Create Registration Object -------- */

//     const registration = new Registration(
//         null,
//         Number(eventId),
//         name,
//         email,
//         phone
//     )

//     registration.validate()


//     /* -------- Save Registration -------- */

//     await createRegistration(registration)


//     /* -------- Update Event Seats -------- */

//     event.availableSeats = event.availableSeats - 1

//     await updateEvent(eventId, event)


//     showSuccess("Registration successful!")

//     form.reset()

// } catch (error) {

//     showError(error.message)

// }


// }


import Registration from "../models/Registration.js"

import {
getEventById,
updateEvent,
createRegistration
} from "../services/apiService.js"

import {
showError,
showSuccess,
getQueryParam
} from "../utils/helpers.js"

import {
isRequired,
isValidEmail,
isValidPhone
} from "../utils/validation.js"



/* ===============================
Load Event Details
================================ */

export const loadEventDetails = async () => {

    try {

        const eventId = getQueryParam("eventId")

        if (!eventId) return

        const event = await getEventById(eventId)

        const container = document.getElementById("eventDetails")

        if (!container) return

        container.innerHTML = `
            <h2>${event.title}</h2>
            <p>${event.description}</p>
            <p><b>Date:</b> ${event.date}</p>
            <p><b>Location:</b> ${event.location}</p>
            <p><b>Available Seats:</b> ${event.availableSeats}</p>
        `

    } catch (error) {

        showError("Failed to load event details")

    }

}



/* ===============================
Handle Registration
================================ */

export const handleRegistration = async (form) => {

    try {

        const eventId = getQueryParam("eventId")

        const name = form.participantName.value
        const email = form.email.value
        const phone = form.phone.value


        if (!isRequired(name)) return showError("Name required")

        if (!isValidEmail(email)) return showError("Invalid email")

        if (!isValidPhone(phone)) return showError("Phone must be 10 digits")


        const event = await getEventById(eventId)

        if (event.availableSeats <= 0) {
            return showError("No seats available")
        }


        // const registrationData = {
        //     eventId: Number(eventId),
        //     participantName: name,
        //     email: email,
        //     phone: phone
        // }

        // await createRegistration(registrationData)

        const registrationData = {
            eventId: eventId,
            participantName: name,
            email: email,
            phone: phone
        }

        await createRegistration(registrationData)


        event.availableSeats = event.availableSeats - 1

        await updateEvent(eventId, event)


        showSuccess("Registration successful!")

        form.reset()

    } catch (error) {

        showError(error.message)

    }

}