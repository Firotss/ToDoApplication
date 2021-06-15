-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Июн 15 2021 г., 08:05
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
  `title` varchar(50) NOT NULL,
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
(1, 'title', '2021-06-15 02:36:58', 1, '2021-06-15 02:36:58', 1, 1, 0),
(2, 'title2', '2021-06-15 02:37:13', 1, '2021-06-15 02:37:13', 1, 1, 0),
(3, 'One', '2021-06-15 03:00:29', 2, '2021-06-15 03:00:29', 2, 2, 0),
(4, 'Two', '2021-06-15 03:00:33', 2, '2021-06-15 03:00:33', 2, 2, 0),
(5, 'Three', '2021-06-15 03:00:38', 2, '2021-06-15 03:00:38', 2, 2, 0),
(6, 'Four', '2021-06-15 03:00:44', 2, '2021-06-15 03:00:44', 2, 2, 0),
(7, 'Five', '2021-06-15 03:00:47', 2, '2021-06-15 03:00:47', 2, 2, 0),
(8, 'Six', '2021-06-15 03:00:51', 2, '2021-06-15 03:00:51', 2, 2, 0),
(9, 'Seven', '2021-06-15 03:08:28', 2, '2021-06-15 03:08:28', 2, 2, 0),
(10, 'Eight', '2021-06-15 03:16:58', 2, '2021-06-15 03:16:58', 2, 2, 0),
(11, 'Nine', '2021-06-15 03:17:41', 2, '2021-06-15 03:17:41', 2, 2, 0),
(12, 'Ten', '2021-06-15 03:19:35', 2, '2021-06-15 03:19:35', 2, 2, 0),
(13, 'Eleven', '2021-06-15 03:20:00', 2, '2021-06-15 03:20:00', 2, 2, 0),
(14, 'Twelve', '2021-06-15 03:21:04', 2, '2021-06-15 03:21:04', 2, 2, 0),
(15, 'Threeteen', '2021-06-15 03:22:42', 2, '2021-06-15 03:22:42', 2, 2, 0),
(16, 'Fourteen', '2021-06-15 03:23:20', 2, '2021-06-15 03:23:20', 2, 2, 0),
(17, 'Fiveteen', '2021-06-15 03:23:46', 2, '2021-06-15 03:23:46', 2, 2, 0),
(18, 'Sixteen', '2021-06-15 03:25:40', 2, '2021-06-15 03:25:40', 2, 2, 0),
(19, 'Seventeen', '2021-06-15 03:25:52', 2, '2021-06-15 03:25:52', 2, 2, 0),
(20, 'abv', '2021-06-15 04:21:59', 2, '2021-06-15 04:21:59', 2, 2, 0),
(21, 'avv', '2021-06-15 04:24:58', 2, '2021-06-15 04:24:58', 2, 2, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
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
(2, 'firots', '123321', 'kirill', 'domrachev', '2021-06-14 00:00:00', 1, '2021-06-14 00:00:00', 1),
(7, 'baba', '123321', 'bab', 'ded', '2021-06-14 00:00:00', 1, '0000-00-00 00:00:00', 1);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `todolists`
--
ALTER TABLE `todolists`
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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
