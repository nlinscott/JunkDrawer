<?php


class Vote{
    
    public function Vote(){
        
    }
    
    public function castVote($number, $id){
        
        require_once('config/config.php');
        
        $con = mysqli_connect(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);
        
        if(!$con){
            mysqli_close($con);            
        }
        
        
        
        //gets a set number of existing months
        $sql = "UPDATE `ideas` 
                SET `votes` = `votes` + $number
                WHERE `ID` = $id";
            
        
        //execute query
        mysqli_query($con, $sql);
        
        mysqli_close($con);
                 
    }
    
    
}



?>