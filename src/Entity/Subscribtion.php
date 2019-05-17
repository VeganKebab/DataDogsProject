<?php

namespace App\Entity;

use Doctrine\ORM\Mapping as ORM;

/**
 * @ORM\Entity(repositoryClass="App\Repository\SubscribtionRepository")
 */
class Subscribtion
{
    /**
     * @ORM\Id()
     * @ORM\GeneratedValue()
     * @ORM\Column(type="integer")
     */
    private $id;

    /**
     * @ORM\Column(type="integer", length=255)
     */
    private $UserID;

    /**
     * @ORM\Column(type="integer", length=255)
     */
    private $categoryID;

    public function getId(): ?int
    {
        return $this->id;
    }

    public function getUserID(): ?int
    {
        return $this->UserID;
    }

    public function setUserID(int $UserID): self
    {
        $this->UserID = $UserID;

        return $this;
    }

    public function getEventID(): ?int
    {
        return $this->EventID;
    }

    public function setEventID(int $categoryID): self
    {
        $this->categoryID = $categoryID;

        return $this;
    }
}
