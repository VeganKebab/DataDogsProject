<?php

namespace App\Controller;

use App\Entity\Category;
use App\Entity\Event;
use Doctrine\DBAL\Types\TextType;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Form\Extension\Core\Type\SubmitType;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\Routing\Annotation\Route;

class CategoryController extends AbstractController
{
    /**
     * @Route("/category", name="category")
     */
    public function Category(Request $request)
    {
       $categories = $this->getDoctrine()->getRepository(Category::class)->findAll();
        return $this->render('category/view.html.twig', [
            'categories' => $categories
        ]);
    }

    /**
     * @Route("/categorydel/{name}", name="category_delete")
     */
    public function CategoryDelete(Request $request, $name)
    {
        $category = $this->getDoctrine()->getRepository(Category::class)->findOneBy(['Name' => $name]);
        $entitymanager = $this->getDoctrine()->getManager();
        $entitymanager->remove($category);
        $entitymanager->flush();
        return $this->redirectToRoute('category');
    }

    /**
     * @Route("/category/create", name="category_create")
     */
    public function createCategory(Request $request)
    {
        $category = new Category();

        $form = $this->createFormBuilder($category)
            ->add('Name')
            ->add('save', SubmitType::class, array(
                'label' => 'Create',
            ))
            ->getForm();

        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid())
        {
            $category = $form->getData();

            $entityManager = $this->getDoctrine()->getManager();
            $entityManager->persist($category);
            $entityManager->flush();

            return $this->redirectToRoute('category');
        }
        return $this->render('category/new.html.twig', [
            'form' => $form->createView()
        ]);
    }
}
