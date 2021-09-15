<?php
include 'booking.php';
include 'config.php';



if ($_SERVER["REQUEST_METHOD"] == "POST") {
    }
    if (($_POST["username"])) {
    $username= test_input($_POST["username"]);
    }
  if (($_POST["date"])) {
    $date= test_input($_POST["date"]);
    }
  if (($_POST["time"])) {
    $time = test_input($_POST["time"]);
    }
    
if (($_POST["persons"])) {
    $persons = test_input($_POST["persons"]);
    }
  
  if (($_POST["tables"])) {
    $tables = test_input($_POST["tables"]);
  }

  function test_input($data) {
  $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;
}

$sql = "INSERT INTO book (username,date,time,persons,tables)
VALUES ('$username','$date','$time','$persons','$tables')";

if ($conn->query($sql) === TRUE) {
    echo "Successfull";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();

?>

