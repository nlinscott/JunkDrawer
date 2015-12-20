<?php


class GetIdea{
    
    public function GetIdea(){
        
    }
    
    public function getIdeaByID($id){
        
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
                     i.idea_name as IdeaName,
                     c.category as Category

                FROM `ideas` as i

                INNER JOIN `categories` as c ON c.category_id = i.category_id

                WHERE i.id = $id";
            
        
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