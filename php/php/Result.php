<?php

/**
* This is a class that will give us errors in the form of JSON
* As JSON, we can safely return a result to the client and provide the 
* appropriate feedback to the user
*/
namespace Database;

class Result{
    
    /**
     *
     * can return just this json string 
     *
     */
    public static function GetJSONError($message){
        $array = array("result" => 
                           array(
                               "success" => false,
                               "message" => $message
                           )
                      );
        return json_encode($array);
    }
    
    /**
     *
     * get this array and add it to result set first. We can check
     * this result client side since the schema is the same
     *
     */
    public static function GetSuccessArray($resultCount){
        $array = array("result" => 
                            array(
                                "success" => true,
                                "message" => $resultCount . " results found.")
                       );
        return $array;
    }
}


?>