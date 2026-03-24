// export default class Event{

//     constructor(title,date,location,capacity){
//         this.title = title;
//         this.date =date;
//         this.location=location;
//         this.capacity=capacity;
//         this.avalibleseats = capacity;
//     }

// }


export default class Event {


// Constructor initializes event object
constructor(id, title, description, date, location, capacity, availableSeats = capacity) {
    this.id = id
    this.title = title
    this.description = description
    this.date = date
    this.location = location
    this.capacity = capacity
    this.availableSeats = availableSeats
}

// Validate event data before saving
validate() {

    if (!this.title || this.title.trim() === "") {
        throw new Error("Event title is required")
    }

    if (!this.location || this.location.trim() === "") {
        throw new Error("Event location is required")
    }

    const eventDate = new Date(this.date)
    const today = new Date()

    // remove time from today's date
    today.setHours(0,0,0,0)

    if (eventDate < today) {
        throw new Error("Event date cannot be in the past")
    }

    if (this.capacity <= 0) {
        throw new Error("Capacity must be greater than 0")
    }

    return true
}

// Check if seats are available
hasSeatsAvailable() {
    return this.availableSeats > 0
}

// Reduce seat when registration happens
bookSeat() {

    if (!this.hasSeatsAvailable()) {
        throw new Error("No seats available for this event")
    }

    this.availableSeats = this.availableSeats - 1
}


}
