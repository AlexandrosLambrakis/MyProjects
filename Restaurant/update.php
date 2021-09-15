<?php
include 'config.php';
include 'monitoring.php';

if(isset($_GET))
{
    //get values
    $id=$_GET['id'];
    $date=$_GET['date'];
    $time=$_GET['time'];
    $persons=$_GET['persons'];
    $tables =$_GET['tables'];
  }
//Update user details
$sql=" UPDATE book SET date='.$date.',time='.$time.',persons='.$persons.',tables='.$tables.' WHERE id=$_GET[id]";
if(mysqli_query($conn,$sql)){
header("refresh:1; url=monitoring.php");}
    else {
        echo "Not Updated";  
    }
?>
