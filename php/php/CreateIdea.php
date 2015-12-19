<?php


class CreateIdea{
    
    public function CreateIdea(){
        
    }
    
    public function create($idea_name, $description, $author, $category_id){
        
        require_once('config/config.php');
        
        $con = mysqli_connect(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);
        
        if(!$con){
            mysqli_close($con);            
        }
        
        
        $sql = "INSERT INTO `ideas`
                (`ID`, `idea_name`, `description`, `author`, `category_id`, `votes`, `expires`, `permanent`) 
                VALUES 
                (NULL, '$idea_name','$description', '$author', $category_id, 0, NOW() + INTERVAL 2 DAY, 0)";
        
        //execute query
        $result = mysqli_query($con, $sql);
        
        if($result){
            
        }else{
            echo mysqli_error($con);
        }
        
    
        mysqli_close($con);
    }
    
    
}



?>