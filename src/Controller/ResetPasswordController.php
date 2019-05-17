<?php

namespace App\Controller;

use App\Entity\User;
use DateInterval;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\Routing\Annotation\Route;
use Symfony\Component\Security\Core\Encoder\UserPasswordEncoderInterface;

class ResetPasswordController extends AbstractController
{
    /**
     * @Route("/reset/", name="reset_password")
     */
    public function index(Request $request, \Swift_Mailer $mailer)
    {
        $username = $request->get('_username2');

        $this->addFlash('success', 'Email sent');
        if ($username != null) {
            $user = new User();
            $user = $this->getDoctrine()->getRepository(User::class)->findOneBy(['username' => $username]);
            $message = (new \Swift_Message('Project password reset'))
                ->setFrom('ddproject713@gmail.com')
                ->setTo($user->getEmail())
                ->setBody(
                    $this->renderView(
                        'emails/registration.html.twig',
                        ['user' => $user
                            ]
                    ),
                    'text/html'
                );
            $mailer->send($message);
            return $this->redirectToRoute('home_page');
        }
        return $this->render('reset_password/index.html.twig');
    }

    /**
     * @Route("/reset/password", name="resetpasschange")
     */
    public function resetPassword(Request $request, UserPasswordEncoderInterface $passwordEncoder)
    {

        if ($request->get('_token') != null && $request->get('_username') != null) {
            $token = $request->get('_token');
            $username = $request->get('_username');
            $user = $this->getDoctrine()->getRepository(User::class)->findOneBy(['username' => $username]);
            if ($token == $user->getResetToken()) {
                $new_pwd = $request->get('new_password');
                $new_pwd_confirm = $request->get('new_password_confirm');
                if ($new_pwd != null && $new_pwd == $new_pwd_confirm) {
                    $entityManager = $this->getDoctrine()->getManager();
                    $new_pwd_encoded = $passwordEncoder->encodePassword($user, $new_pwd_confirm);
                    $user->setPassword($new_pwd_encoded);
                    $user->setResetToken($this->getString());
                    $entityManager->flush();
                }
            }
            return $this->redirectToRoute('home_page');

        }
        return $this->render('reset_password/index.html.twig');
    }

    function getString() {
        $n = 10;
        $characters = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';
        $randomString = '';

        for ($i = 0; $i < $n; $i++) {
            $index = rand(0, strlen($characters) - 1);
            $randomString .= $characters[$index];
        }

        return $randomString;
    }

}
