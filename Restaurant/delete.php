<?php
include 'config.php';
include 'monitoring.php';

//Delete user details from book
$sql=" DELETE  FROM book WHERE id='$_GET[id]'";
if(mysqli_query($conn,$sql)){
header("refresh:1; url=monitoring.php");}
    else {
        echo "Not Deleted";  
    }
?>
