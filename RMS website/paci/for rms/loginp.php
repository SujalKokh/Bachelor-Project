<?php
session_start();


?>

<html>
	<head>
		<title>Welcome to RMS Login Page</title>
	</head>
	

<body background="bg.jpg">
<table>
<tr>


	<td height="118"><img src="LOGO.jpg" height = 50 width = 50"> <font face = "Comic Sans MS" size = 7 color = "white"> RAMBHAKTA MEMORIAL SCHOOL
	
	
	</font>	
	
</tr>
</table>
<hr>

<form method='post' action='login.php'>
	<table width='400' align='center'>
		
	
	<tr>
		<td><font color="white" size=4 face="Comic Sans MS">User Password:</font></td>
		<td><input type='password' name='pass'/></td>
	</tr>
	<tr>
		<td><font color="white" size=4 face="Comic Sans MS">Email:</font></td>
		<td><input type="text" name='email'/></td>
	</tr>
	<tr>
		<td colspan='3' align='center'><input type="submit" name='login' value="LogIn"/></td>
	</tr>
</table>
</font>
</form>

<center><font color="white" size=5>Not registered Yet? </font><br><a href='registration.php'><font color="white">Sign Up here.</font></a>
</center></font>
</body>
</html>

<?php
mysql_connect("localhost","root","");
mysql_select_db("login_users");

if(isset($_POST['login'])){
	
	$password= $_POST['pass'];
	$email= $_POST['email'];

	$check_user ="select * from users where user_pass='$password' AND user_email='$email'";
	$run=mysql_query($check_user);
	
	if(mysql_num_rows($run)>0)
	{
	$_SESSION['email']=$email;
	echo"<script>window.open('welcome.php','_self')</script>";
	}
	else{
	echo"<script>alert('Email or password is incorrect')</script>";
	
	}
}

?>