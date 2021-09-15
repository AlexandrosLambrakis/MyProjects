<?php
include 'login2.php';
include 'config.php';
 session_start();
 
   if($_SERVER["REQUEST_METHOD"]=="POST") {
      // username and password sent from form 
      
      $username =($_POST['username']);
      $password = ($_POST['password']); 
      // To protect MySQL injection for Security purpose
      $username = stripslashes($username);
      $password = stripslashes($password);

    $sql = "SELECT * FROM users WHERE username='$username' and password='$password'";
    $result = mysqli_query($conn,$sql);
    
 $row = mysqli_fetch_array($result,MYSQLI_ASSOC);
     
      $count = mysqli_num_rows($result);
     
      if($count == 1) {
   $_SESSION['login_user']=$username;
   $_SESSION['role_user'] =$row['roles'];
   $_SESSION['user_id'] =$row['id'];
   
      
      if ( 'admin' == $_SESSION['role_user'] ) {

         header("location: home.php");
      }else if ('user' == $_SESSION['role_user']) {
          header("location:home2.php");
      }
      }else {
          echo "Invalid Username or Password";
      }
   }

?>
