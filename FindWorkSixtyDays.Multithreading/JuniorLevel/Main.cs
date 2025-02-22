﻿namespace FindWorkSixtyDays.Multithreading.JuniorLevel;

public class Main
{
    #region Сухая база

    /* Что такое процесс / поток?
     *
     * Процесс - Простыми словами, это одно запущенное приложение.
     * Поток - какая-либо выполняемая функция этим приложением
     * Как пример, OBS - процесс, а функция записи видео - поток.
     */

    /* Что такое многопоточность
     *
     * Если я хочу выкопать яму и приглашаю кого-то помочь,
     * у нас может произойти коллизия и мы можем столкнуться лопатами
     *
     * Распараллеливание - разбиение задачу на несколько мелких подзадач
     * (Я копаю яму, он убирает землю) это приведет к какому-то результату.
     *
     * Асинхронность - возможность нанять бригаду, которая делает работу вместо нас
     *
     */
    
    /* Отличие многопоточности от асинхронности
     *
     * Многопоточность про то что у нас несколько потоков. Возможна блокировка потока при обращении нескольких потоков
     * к одному ресурсу
     *
     * Асинхронность больше про то, когда есть один поток в рамках процесса, но он переключается в рамках задачи
     * Пока одна задача выполняется, поток переходит на другую задачу.
     */
    
    /* Отличие многопоточности от параллельности
     *
     * В многопоточности у каждого потока свое действие.
     * В параллельности один поток будет разбивать одну задачу на мелкие
     * ( например, нужно перебрать список 1млн строк и они поровну перебирают по 500к )
     */

    #endregion

    #region Конкретика

    /* Понятие принципа Deadlock
     *
     * 
     */

    #endregion
}
