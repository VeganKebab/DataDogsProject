<?php

namespace App\Controller;

use App\Entity\Category;
use App\Entity\Subscribtion;
use App\Entity\User;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Form\Extension\Core\Type\SubmitType;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\Routing\Annotation\Route;

class SubscribtionController extends AbstractController
{
    /**
     * @Route("/subscribtion/{category_id}", name="subscribtion")
     */
    public function index(Request $request, $category_id)
    {
        $subscribtion = new Subscribtion();
        $category = $this->getDoctrine()->getRepository(Category::class)->find($category_id);
        $user = new User();
        $user = $this->getUser();
        if ($category != null && $user != null)
        {
            $subscribtion->setUserID($user->getId());
            $subscribtion->setEventID($category->getId());

            $entityManager = $this->getDoctrine()->getManager();
            $entityManager->persist($subscribtion);
            $entityManager->flush();


        }
        return $this->redirectToRoute('home_page');
    }

    /**
     * @Route("/subs/mailer/{slug}", name="subsmailer")
     */
    public function SubsMailer(Request $request, $slug, \Swift_Mailer $mailer)
    {
        $subs = $this->getDoctrine()->getRepository(Subscribtion::class)->findBy(['categoryID' => $slug]);
        foreach ($subs as $sub)
        {
            $user = $this->getDoctrine()->getRepository(User::class)->findOneBy(['id' => $sub->getUserID()]);
            $category = $this->getDoctrine()->getRepository(Category::class)->find($slug);
            $message = (new \Swift_Message('New event in subscribed category'))
                ->setFrom('ddproject713@gmail.com')
                ->setTo($user->getEmail())
                ->setBody(
                    $this->renderView(
                        'emails/subscribe.html.twig',
                        ['name' => $user->getUsername(),
                            'category' => $category->getName()]
                    ),
                    'text/html'
                );
            $mailer->send($message);
        }
        return $this->redirectToRoute('home_page');

    }
}
