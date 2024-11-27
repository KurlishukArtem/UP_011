-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3307
-- Время создания: Ноя 27 2024 г., 23:39
-- Версия сервера: 5.7.39-log
-- Версия PHP: 8.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `UP_bd`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Material_type`
--

CREATE TABLE `Material_type` (
  `idMaterial_type` int(11) NOT NULL,
  `type_name` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `percent` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `partners`
--

CREATE TABLE `partners` (
  `id` int(11) NOT NULL,
  `type_partner` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `name_partner` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `director` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `e-mail` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `phone` mediumtext COLLATE utf8mb4_unicode_ci,
  `legal_adress` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `INN` mediumtext COLLATE utf8mb4_unicode_ci,
  `raiting` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci COMMENT='																		';

--
-- Дамп данных таблицы `partners`
--

INSERT INTO `partners` (`id`, `type_partner`, `name_partner`, `director`, `e-mail`, `phone`, `legal_adress`, `INN`, `raiting`) VALUES
(10, 'доскоукладочный', 'Такелаж ООО', 'Чжен', '', '88005553535', 'Луначарского 43', '8664824', 5);

-- --------------------------------------------------------

--
-- Структура таблицы `partner_products`
--

CREATE TABLE `partner_products` (
  `idpartner` int(11) NOT NULL,
  `product` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `name_partner` int(11) DEFAULT NULL,
  `number_prod` int(11) DEFAULT NULL,
  `date_sale` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `products`
--

CREATE TABLE `products` (
  `idproducts` int(11) NOT NULL,
  `name_prod` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `article` int(11) DEFAULT NULL,
  `min_cost` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `product_type`
--

CREATE TABLE `product_type` (
  `idprod` int(11) NOT NULL,
  `prod_name` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `coeficent` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Material_type`
--
ALTER TABLE `Material_type`
  ADD PRIMARY KEY (`idMaterial_type`);

--
-- Индексы таблицы `partners`
--
ALTER TABLE `partners`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `partner_products`
--
ALTER TABLE `partner_products`
  ADD PRIMARY KEY (`idpartner`);

--
-- Индексы таблицы `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`idproducts`);

--
-- Индексы таблицы `product_type`
--
ALTER TABLE `product_type`
  ADD PRIMARY KEY (`idprod`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Material_type`
--
ALTER TABLE `Material_type`
  MODIFY `idMaterial_type` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `partners`
--
ALTER TABLE `partners`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблицы `partner_products`
--
ALTER TABLE `partner_products`
  MODIFY `idpartner` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `products`
--
ALTER TABLE `products`
  MODIFY `idproducts` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `product_type`
--
ALTER TABLE `product_type`
  MODIFY `idprod` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
