<?php
include 'register.php';
include 'config.php';
session_start();


if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if (($_POST["fname"])) {
    $fname = test_input($_POST["fname"]);
    }
  }
  if (($_POST["lname"])) {
    $lname= test_input($_POST["lname"]);
    }
  if (($_POST["email"])) {
    $email = test_input($_POST["email"]);
    }
    
if (($_POST["phone"])) {
    $phone = test_input($_POST["phone"]);
    }
  
  if (($_POST["username"])) {
    $username = test_input($_POST["username"]);
  }

  if (($_POST["password"])) {
    $password = test_input($_POST["password"]);
    }

  function test_input($data) {
  $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;
}

$sql="SELECT * FROM users WHERE username='".$username."'";
$result = mysqli_query($conn,$sql);
if (mysqli_num_rows($result) >0){
    echo 'Username already exists';
} else if (mysqli_num_rows($result) ==0){
    $sql = "INSERT INTO users (roles,firstname,lastname,email,phone,username,password)
VALUES ('user','$fname','$lname','$email','$phone','$username','$password')";


if ($conn->query($sql) === TRUE) {
    echo "New record created successfully";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}
    
}
$conn->close();

?>