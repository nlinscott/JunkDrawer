<?php


class Categories{
    
    public function Categories(){
        
    }
    
    public function getAllCategories(){
        
        require_once('config/config.php');
        
        $con = mysqli_connect(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);
        
        if(!$con){
            mysqli_close($con);            
        }
        
        
        
        //gets a set number of existing months
        $sql = "SELECT
                    `category_id` as CategoryID,
                    `category` as CategoryName
                     FROM `categories`";
            
        
        //execute query
        $result =  mysqli_query($con, $sql);
        
        // Put them in array
        for($i = 0; $array[$i] = mysqli_fetch_assoc($result); $i++) ;
    
        // Delete last empty one
        array_pop($array);
            
        mysqli_free_result($result);
        mysqli_close($con);
                 
        echo json_encode($array);
    }
    
    
}



?>