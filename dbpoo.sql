-- Banco de dados: `dbpoo`
--
CREATE DATABASE IF NOT EXISTS `dbpoo` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `dbpoo`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `netflix`
--

DROP TABLE IF EXISTS `netflix`;
CREATE TABLE IF NOT EXISTS `netflix` (
  `id` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(45) NOT NULL,
  `assistindo_no_momento` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `netflix`
--

INSERT INTO `netflix` (`id`, `usuario`, `assistindo_no_momento`) VALUES
(2, 'João', 'Iron Man');