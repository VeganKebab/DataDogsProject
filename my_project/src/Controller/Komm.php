<?php
/**
 * Created by PhpStorm.
 * User: Lenovo
 * Date: 04/09/2019
 * Time: 17:25
 */

namespace App\Controller;


use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Symfony\Component\HttpFoundation\Response;

class Komm
{
    /**
     * @Route("/")
     */
    public function Homepage(){
        return new Response("WOOOGOOO");
    }

}