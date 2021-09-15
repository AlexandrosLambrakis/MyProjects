<?php
$servername = "localhost";
$firstname = "root";
$password = "";
$dbname = "registration";

// Create connection
$conn = new mysqli($servername, $firstname, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 
?>