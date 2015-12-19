<?php


class GetAllBad{
    
    public function GetAllBad(){
        
    }
    
    public function getAllBadIdeas(){
        
        require_once('config/config.php');
        
        $con = mysqli_connect(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);
        
        if(!$con){
            mysqli_close($con);            
        }
        
        
        //gets a set number of existing months
        $sql = "SELECT 
                     i.author as Author,
                     i.description as Description,
                     i.id as ID,
                     i.votes as VoteCount,
                     i.expires as Expiration,
                     i.permanent as IsPermanent,
                     i.idea_name as IdeaName,
                     c.category as Category

                FROM `ideas` as i

                INNER JOIN `categories` as c ON c.category_id = i.category_id

                WHERE i.permanent = 0";
            
        
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