import Event from "../models/Event.js"

import {
    getEvents,
    createEvent,
    deleteEvent,
    getRegistrations
} from "../services/apiService.js"

import {
    showError,
    showSuccess,
    formatDate
} from "../utils/helpers.js"

import {
    isRequired,
    isFutureDate,
    isPositiveNumber
} from "../utils/validation.js"



/* ============================
   Load and display events
============================ */

export const loadEvents = async () => {

    try {

        const events = await getEvents()

        const eventContainer = document.getElementById("eventList")

        if (!eventContainer) return

        eventContainer.innerHTML = ""

        events.forEach(event => {

            const { id, title, description, date, location, availableSeats } = event

            const card = `
            <div class="event-card">

                <h3>${title}</h3>

                <p>${description}</p>

                <p><b>Date:</b> ${formatDate(date)}</p>

                <p><b>Location:</b> ${location}</p>

                <p><b>Available Seats:</b> ${availableSeats}</p>

                <button class="register-btn" data-id="${id}">
                    Register
                </button>

                <button class="delete-btn" data-id="${id}">
                    Delete
                </button>

            </div>
            `

            eventContainer.innerHTML += card

        })

        attachEventButtons()

    } catch (error) {

        showError("Failed to load events")

    }

}



/* ============================
   Attach button actions
============================ */

const attachEventButtons = () => {

    const registerButtons = document.querySelectorAll(".register-btn")

    registerButtons.forEach(btn => {

        btn.addEventListener("click", () => {

            const eventId = btn.dataset.id

            window.location.href = `register.html?eventId=${eventId}`

        })

    })


    const deleteButtons = document.querySelectorAll(".delete-btn")

    deleteButtons.forEach(btn => {

        btn.addEventListener("click", async () => {

            const eventId = btn.dataset.id

            await handleDeleteEvent(eventId)

        })

    })

}



/* ============================
   Add Event
============================ */

export const handleAddEvent = async (form) => {

    try {

        const title = form.title.value
        const description = form.description.value
        const date = form.date.value
        const location = form.location.value
        const capacity = form.capacity.value


        /* ---- Validation ---- */

        if (!isRequired(title)) {
            return showError("Title is required")
        }

        if (!isRequired(location)) {
            return showError("Location is required")
        }

        if (!isFutureDate(date)) {
            return showError("Date cannot be in the past")
        }

        if (!isPositiveNumber(capacity)) {
            return showError("Capacity must be a positive number")
        }


        /* ---- Create Event Object ---- */

        const event = new Event(
            null,
            title,
            description,
            date,
            location,
            Number(capacity),
            Number(capacity)
        )

        event.validate()


        /* ---- Convert to plain object (IMPORTANT) ---- */

        const eventData = {
            title: event.title,
            description: event.description,
            date: event.date,
            location: event.location,
            capacity: event.capacity,
            availableSeats: event.availableSeats
        }


        /* ---- Save event ---- */

        await createEvent(eventData)

        showSuccess("Event created successfully")

        form.reset()

    } catch (error) {

        showError(error.message)

    }

}



/* ============================
   Delete Event
============================ */

const handleDeleteEvent = async (eventId) => {

    try {

        const registrations = await getRegistrations()

        const exists = registrations.some(r => r.eventId == eventId)

        if (exists) {
            return showError("Cannot delete event with registrations")
        }

        const confirmDelete = confirm("Are you sure you want to delete this event?")

        if (!confirmDelete) return

        await deleteEvent(eventId)

        showSuccess("Event deleted successfully")

        loadEvents()

    } catch (error) {

        showError("Error deleting event")

    }

}