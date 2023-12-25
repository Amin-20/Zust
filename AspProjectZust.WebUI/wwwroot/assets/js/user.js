﻿"use strict"

var connection = new signalR.HubConnectionBuilder().withUrl("/userhub").build();

connection.start().then(function () {
    //GetAllUsers();
    console.log("Connected");
}).catch(function (err) {
    return console.error(err.toString());
})

let element = document.querySelector("#alert");
connection.on("Connect", function (info) {
    console.log("Eynall");
    //GetAllUsers();
    //element.style.display = "block";
    //element.innerHTML = info;
    //setTimeout(() => {
    //    element.innerHTML = "";
    //    element.style.display = "none";
    //}, 5000);
})
//connection.on("Disconnect", function (info) {
//    console.log("DisConnect Work");
//    GetAllUsers();
//    element.style.display = "block";
//    element.innerHTML = info;
//    setTimeout(() => {
//        element.innerHTML = "";
//        element.style.display = "none";
//    }, 5000);
//})

//async function SendFollowCall(id) {
//    await connection.invoke("SendFollow", id);
//}

//async function GetMessageCall(receiverId, senderId) {
//    await connection.invoke("GetMessages", receiverId, senderId);
//}


//connection.on("ReceiveMessages", function (receiverId, senderId) {
//    GetMessages(receiverId, senderId);
//})
//connection.on("ReceiveNotification", function () {
//    GetMyRequests();
//    GetAllUsers();
//})