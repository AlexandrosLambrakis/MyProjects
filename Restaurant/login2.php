<html>
    <head>
        <meta charset="UTF-8">
    <title>Login Form</title>
    <link rel="stylesheet" type="text/css" href="css/style.css">
    </head>
    <body>
        <div class="header">
            <h1>Login Form</h1>
        </div>
    
        <form  method="post" action="login.php">
     
            <table> 
                <tr>
                    <td>Username:</td>
                    <td><input type="text" name="username" placeholder="username"  required autofocus></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><input type="password" name="password" placeholder="password" required></td>
                </tr>
                <tr>
                    <td></td>
                    <td><input type="submit" name="login_button" value="Login"/> <input type="submit" name="register_button" value="Register" onclick="location.href='register.php';"/></td>
                </tr>
               
            </table>
            
        </form>
    </body>
        <p>
    <a href="http://css-validator.org/check/referer">
        <img style="border:0;width:88px;height:31px"
            src="http://css-validator.org/images/vcss.png"
            alt="Valid CSS!" />
    </a>
</p>
      <p>
<a href="http://css-validator.org/check/referer">
    <img style="border:0;width:88px;height:31px"
        src="http://css-validator.org/images/vcss-blue.png"
        alt="Valid CSS!" />
</a>
</p>
       
</html>


