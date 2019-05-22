<?php

	$polaczenie = @new mysqli('localhost','root','','unity');
	
	if($polaczenie->connect_errno == 0)
	{
		if(isset($_POST['nick']) && isset($_POST['pass']) )
		{
			$nick = $_POST['nick'];
			$pass = $_POST['pass'];
			
			$rezultat = mysqli_query($polaczenie, "SELECT * FROM gracze WHERE nick='$nick'");
			
			if($rezultat->num_rows == 0)
			{
				mysqli_query($polaczenie, "INSERT INTO gracze (nick, pass) VALUES('$nick','$pass')");
				echo 'Użytkownik został zarejestrowany!';
			}
			else
			{
				echo 'Taki użytkownik juz istnieje';
			}
		}
		
		$polaczenie->close();		
	}
?>