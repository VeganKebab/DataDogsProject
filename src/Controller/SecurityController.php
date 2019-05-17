<?php

namespace App\Controller;

use App\Entity\Event;
use App\Entity\User;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\Routing\Annotation\Route;
use Symfony\Component\Security\Core\Encoder\UserPasswordEncoderInterface;
use Symfony\Component\Security\Http\Authentication\AuthenticationUtils;

class SecurityController extends AbstractController
{
    /**
     * @Route("/login", name="login")
     */
    public function login(Request $request, AuthenticationUtils $utils)
    {
        $error = $utils->getLastAuthenticationError();

        $lastUsername = $utils->getLastUsername();


        return $this->render('security/login.html.twig', [
            'error' => $error,
            'last_username' => $lastUsername
        ]);
    }

    /**
     * @Route("/logout", name="logout"))
     */
    public function logout(){

    }

    /**
     * @Route("/User/Edit/{username}", name="user_edit")
     */
    public function changePassword(Request $request, $username, UserPasswordEncoderInterface $passwordEncoder)
    {
        $user = new User();
        $user = $this->getDoctrine()->getRepository(User::class)->findOneBy(['username' => $username]);
        $old_pwd = $request->get('old_password');
        $new_pwd = $request->get('new_password');
        $new_pwd_confirm = $request->get('new_password_confirm');

        $checkPass = $passwordEncoder->isPasswordValid($user, $old_pwd);
        if ($checkPass == true && $new_pwd == $new_pwd_confirm)
        {
            $entityManager = $this->getDoctrine()->getManager();
            $new_pwd_encoded = $passwordEncoder->encodePassword($user, $new_pwd_confirm);
            $user->setPassword($new_pwd_encoded);


            $entityManager->flush();

            // do anything else you need here, like send an email

            return $this->redirectToRoute('home_page');
        }
        return $this->render('security/edit.html.twig');
    }

    /**
     * @Route("/user/delete/", name="delete_user")
     */
    public function DeleteUser(Request $request)
    {
        $user = new User();
        $deleteID = $request->get('iddelete');
        if ($deleteID != null) {
            $user = $this->getDoctrine()->getRepository(User::class)->find($deleteID);
            $entitymanager = $this->getDoctrine()->getManager();
            $entitymanager->remove($user);
            $entitymanager->flush();
            return $this->redirectToRoute('home_page');
        }
        return $this->render('security/delete.html.twig');
    }


}
