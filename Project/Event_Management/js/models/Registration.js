// class Registration{
// constructor(eventID, name, emailID, phone){
//     this.eventID =eventID;
//     this.name = name;
//     this.emailID = emailID;
//     this.phone = phone;
// }
    

// }


export default class Registration {

// Constructor initializes registration object
constructor(id, eventId, participantName, email, phone) {
    this.id = id
    this.eventId = eventId
    this.participantName = participantName
    this.email = email
    this.phone = phone
}

// Validate registration details
validate() {

    if (!this.participantName || this.participantName.trim() === "") {
        throw new Error("Participant name is required")
    }

    // Email validation
    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/

    if (!emailPattern.test(this.email)) {
        throw new Error("Invalid email format")
    }

    // Phone validation (10 digits)
    const phonePattern = /^[0-9]{10}$/

    if (!phonePattern.test(this.phone)) {
        throw new Error("Phone number must be 10 digits")
    }

    return true
}

}
