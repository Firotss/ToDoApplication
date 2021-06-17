-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Июн 17 2021 г., 06:54
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
(16, 'jesus', 'god', 'Petar', 'Petrov', '2021-06-15 15:21:46', 1, '2021-06-15 15:21:46', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `usersneedtodo`
--

CREATE TABLE `usersneedtodo` (
  `id` int(11) NOT NULL,
  `id_of_the_task` int(11) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
-- Индексы таблицы `usersneedtodo`
--
ALTER TABLE `usersneedtodo`
  ADD PRIMARY KEY (`id`);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT для таблицы `usersneedtodo`
--
ALTER TABLE `usersneedtodo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
