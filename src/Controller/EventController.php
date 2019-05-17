<?php

namespace App\Controller;

use App\Entity\Category;
use App\Entity\Event;
use App\Form\EventFormType;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Form\Extension\Core\Type\ChoiceType;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;

class EventController extends AbstractController
{
    /**
     * @Route("/event", name="event")
     */
    public function createEvent(Request $request)
    {
        $categories = $this->getDoctrine()->getRepository(Category::class)->findAll();
        $event = new Event();
        $form = $this->createForm(EventFormType::class, $event);

        $form->handleRequest($request);


        if ($form->isSubmitted() && $form->isValid())
        {
            $entityManager = $this->getDoctrine()->getManager();
            $entityManager->persist($event);
            $entityManager->flush();
            $category = $this->getDoctrine()->getRepository(Category::class)->findOneBy(['Name' => $event->getCategory()]);

            // do anything else you need here, like send an email
            return $this->redirectToRoute('subsmailer', ['slug' => $category->getId()]);
        }

        return $this->render('event/create.html.twig', [
            'eventForm' => $form->createView(),
            'categories' => $categories
        ]);
    }

    /**
     * @Route("/event/edit/{id}", name="event_edit")
     */
    public function editEvent(Request $request, $id)
    {
        $event = new Event();
        $event = $this->getDoctrine()->getRepository(Event::class)->find($id);
        $form = $this->createForm(EventFormType::class, $event);
        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid())
        {
            $entityManager = $this->getDoctrine()->getManager();
            $entityManager->flush();

            // do anything else you need here, like send an email

            return $this->redirectToRoute('home_page');
        }
        return $this->render('event/edit.html.twig', [
            'eventForm' => $form->createView(),
        ]);
    }
    /**
     * @Route("/event/{id}", name="view_event")
     */
    public function viewEvent($id)
    {
        $events = $this->getDoctrine()
            ->getRepository(Event::class)
            ->find($id);

        return $this->render('event/view.html.twig', [
            'events'=>$events
        ]);
    }

    /**
     * @Route("/event/delete/{id}", name="delete_event")
     */
    public function Delete($id)
    {
        $events = $this->getDoctrine()->getRepository(Event::class)->find($id);
        $entitymanager = $this->getDoctrine()->getManager();
        $entitymanager->remove($events);
        $entitymanager->flush();
        return $this->redirectToRoute('home_page');
    }
}
