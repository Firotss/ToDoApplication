-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Июн 16 2021 г., 21:45
-- Версия сервера: 10.4.17-MariaDB
-- Версия PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `todoapplications`
--

-- --------------------------------------------------------

--
-- Структура таблицы `todolists`
--

CREATE TABLE `todolists` (
  `id` int(11) NOT NULL,
  `title` varchar(30) NOT NULL,
  `date_of_creation` datetime NOT NULL,
  `id_of_the_creator` int(11) NOT NULL,
  `date_of_last_change` datetime NOT NULL,
  `last_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `list_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `todolists`
--

INSERT INTO `todolists` (`id`, `title`, `date_of_creation`, `id_of_the_creator`, `date_of_last_change`, `last_id`, `user_id`, `list_id`) VALUES
(69, 'Banichka4', '2021-06-15 16:36:41', 16, '2021-06-16 19:02:21', 16, 16, 69),
(70, 'Banichka4', '2021-06-15 16:36:41', 16, '2021-06-16 19:02:21', 16, 18, 69),
(72, 'a(baba)', '2021-06-15 16:39:01', 18, '2021-06-15 16:39:01', 18, 18, 72),
(73, 'Work(test)', '2021-06-15 17:07:32', 19, '2021-06-15 17:07:32', 19, 19, 73),
(76, 'a(test)', '2021-06-15 17:09:43', 19, '2021-06-15 17:09:43', 19, 19, 76),
(81, 'av(baba)', '2021-06-15 19:14:21', 18, '2021-06-15 19:14:21', 18, 18, 81),
(84, 'aaaaaaaaaaaa(jesus)', '2021-06-16 01:30:50', 16, '2021-06-16 20:00:05', 16, 16, 84),
(85, 'a(jesus)', '2021-06-16 01:38:18', 16, '2021-06-16 01:38:18', 16, 16, 85),
(87, 'abv(jesus)', '2021-06-16 02:00:42', 16, '2021-06-16 02:00:42', 16, 16, 87),
(90, 'abv(jesus)', '2021-06-16 18:01:22', 16, '2021-06-16 19:13:06', 16, 16, 90),
(91, 'a(jesus)', '2021-06-16 19:18:07', 16, '2021-06-16 19:18:07', 16, 16, 91),
(92, 'a(jesus)', '2021-06-16 19:18:09', 16, '2021-06-16 19:23:25', 16, 16, 92),
(93, 'a(jesus)', '2021-06-16 19:18:10', 16, '2021-06-16 19:18:10', 16, 16, 93),
(94, 'a(jesus)', '2021-06-16 19:18:11', 16, '2021-06-16 19:18:11', 16, 16, 94),
(100, 'Adventure(jojo)', '2021-06-16 20:50:00', 20, '2021-06-16 20:56:24', 21, 20, 100),
(101, 'Adventure(jojo)', '2021-06-16 20:50:00', 20, '2021-06-16 20:56:24', 21, 21, 100),
(103, 'TasksToday(jojo)', '2021-06-16 21:42:01', 20, '2021-06-16 21:42:01', 20, 20, 103),
(104, 'a(jojo)', '2021-06-16 21:50:15', 20, '2021-06-16 21:50:15', 20, 20, 104),
(105, 'a(jojo)', '2021-06-16 21:53:22', 20, '2021-06-16 21:53:22', 20, 20, 105),
(106, 'a(jojo)', '2021-06-16 21:53:22', 20, '2021-06-16 21:53:22', 20, 21, 105);

-- --------------------------------------------------------

--
-- Структура таблицы `todotasks`
--

CREATE TABLE `todotasks` (
  `id` int(11) NOT NULL,
  `id_of_the_list` int(11) NOT NULL,
  `title` varchar(20) NOT NULL,
  `description` varchar(300) DEFAULT NULL,
  `isComplete` tinyint(1) NOT NULL,
  `date_of_creation` datetime NOT NULL,
  `id_of_creator` int(11) NOT NULL,
  `date_of_last_change` datetime NOT NULL,
  `last_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `todotasks`
--

INSERT INTO `todotasks` (`id`, `id_of_the_list`, `title`, `description`, `isComplete`, `date_of_creation`, `id_of_creator`, `date_of_last_change`, `last_id`) VALUES
(1, 84, 'NO', 'addadadadad', 0, '2021-06-16 16:41:17', 0, '2021-06-16 16:41:17', 0),
(2, 84, 'The new task!', 'description', 0, '2021-06-16 17:46:49', 16, '2021-06-16 18:49:18', 16),
(3, 80, 'a(jesus)', NULL, 0, '2021-06-16 17:47:21', 16, '2021-06-16 17:47:21', 16),
(4, 69, 'Banichka4', 'hello', 0, '2021-06-16 18:54:47', 18, '2021-06-16 19:02:21', 16),
(5, 84, 'abaa(jesus)', '', 0, '2021-06-16 19:08:45', 16, '2021-06-16 19:12:24', 16),
(6, 84, 'aaaaaaaaaaaa(jesus)', NULL, 0, '2021-06-16 19:10:03', 16, '2021-06-16 19:10:03', 16),
(7, 84, 'abv', '', 0, '2021-06-16 19:10:09', 16, '2021-06-16 19:23:25', 16),
(9, 90, '', '', 0, '2021-06-16 19:12:53', 16, '2021-06-16 19:13:06', 16),
(10, 90, 'abv(jesus)', NULL, 0, '2021-06-16 19:12:56', 16, '2021-06-16 19:12:56', 16),
(11, 92, 'abv', '', 0, '2021-06-16 19:22:24', 16, '2021-06-16 19:23:25', 16),
(13, 100, 'Kill Dio', NULL, 0, '2021-06-16 21:15:28', 20, '2021-06-16 21:15:28', 20),
(14, 100, 'ab', NULL, 0, '2021-06-16 21:23:32', 20, '2021-06-16 21:23:32', 20),
(15, 0, 'Homework', 'Сделай математику, болгарский и наконец то доделай проект', 0, '2021-06-16 21:42:33', 20, '2021-06-16 21:52:10', 20);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(15) NOT NULL,
  `password` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `date_of_creation` datetime NOT NULL,
  `id_of_creator` int(11) NOT NULL,
  `date_of_last_change` datetime NOT NULL,
  `last_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `first_name`, `last_name`, `date_of_creation`, `id_of_creator`, `date_of_last_change`, `last_id`) VALUES
(1, 'admin', 'adminpass', 'admin', 'admin', '2021-06-16 00:00:00', 123, '2021-06-14 23:35:19', 0),
(16, 'jesus', 'god', 'Petar', 'Petrov', '2021-06-15 15:21:46', 1, '2021-06-15 15:21:46', 1),
(18, 'baba', '123321', 'bab', 'ded', '2021-06-15 16:37:41', 1, '2021-06-15 16:37:41', 1),
(19, 'test', 'test', 'test', 'test', '2021-06-15 17:07:00', 1, '2021-06-15 17:07:00', 1),
(20, 'jojo', 'dio', 'Jonathan ', 'Joestar', '2021-06-16 20:39:02', 1, '2021-06-16 20:39:02', 1),
(21, 'jojo_father', 'dio', 'Jonathan ', 'Joestar+', '2021-06-16 20:43:17', 1, '2021-06-16 20:43:17', 1);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `todolists`
--
ALTER TABLE `todolists`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `todotasks`
--
ALTER TABLE `todotasks`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQUE` (`username`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `todolists`
--
ALTER TABLE `todolists`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=107;

--
-- AUTO_INCREMENT для таблицы `todotasks`
--
ALTER TABLE `todotasks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
