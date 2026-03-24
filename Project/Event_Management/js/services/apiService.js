const BASE_URL = "http://localhost:3000"

/* ===============================
EVENT APIs
================================*/

// Get all events
export const getEvents = async () => {
try {


    const response = await fetch(`${BASE_URL}/events`)
    const data = await response.json()

    return data

} catch (error) {
    console.error("Error fetching events:", error)
    throw error
}


}

// Get single event by ID
export const getEventById = async (id) => {
try {


    const response = await fetch(`${BASE_URL}/events/${id}`)
    const data = await response.json()

    return data

} catch (error) {
    console.error("Error fetching event:", error)
    throw error
}


}

// Create new event
export const createEvent = async (eventData) => {
try {


    const response = await fetch(`${BASE_URL}/events`, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(eventData)
    })

    const data = await response.json()
    return data

} catch (error) {
    console.error("Error creating event:", error)
    throw error
}


}

// Update event
export const updateEvent = async (id, eventData) => {
try {


    const response = await fetch(`${BASE_URL}/events/${id}`, {
        method: "PUT",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(eventData)
    })

    const data = await response.json()
    return data

} catch (error) {
    console.error("Error updating event:", error)
    throw error
}


}

// Delete event
export const deleteEvent = async (id) => {
try {


    await fetch(`${BASE_URL}/events/${id}`, {
        method: "DELETE"
    })

    return true

} catch (error) {
    console.error("Error deleting event:", error)
    throw error
}


}

/* ===============================
REGISTRATION APIs
================================*/

// Get all registrations
export const getRegistrations = async () => {
try {


    const response = await fetch(`${BASE_URL}/registrations`)
    const data = await response.json()

    return data

} catch (error) {
    console.error("Error fetching registrations:", error)
    throw error
}


}

// Create registration
export const createRegistration = async (registrationData) => {
try {


    const response = await fetch(`${BASE_URL}/registrations`, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(registrationData)
    })

    const data = await response.json()

    return data

} catch (error) {
    console.error("Error creating registration:", error)
    throw error
}


}
