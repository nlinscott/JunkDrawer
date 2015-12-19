<?php


class GetAll{
    
    public function GetAll(){
        
    }
    
    public function getAllIdeas($include_permanent){
        
        require_once('config/config.php');
        
        $con = mysqli_connect(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);
        
        if(!$con){
            mysqli_close($con);            
        }
        
        $perm = 1;
        
        if(!$include_permanent){
            $perm = 0;
        }
        
        //gets a set number of existing months
        $sql = "SELECT 
                     i.description as Description,
                     i.id as ID,
                     i.votes as VoteCount,
                     i.expires as Expiration,
                     i.permanent as IsPermanent,
                     i.IdeaName as IdeaName,
                     c.category as Category

                FROM `ideas` as i

                INNER JOIN `categories` as c ON c.category_id = i.category_id

                WHERE i.permanent = $perm";
            
        
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