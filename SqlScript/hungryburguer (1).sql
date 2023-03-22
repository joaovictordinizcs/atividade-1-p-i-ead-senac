CREATE DATABASE hungryburguer;


--

CREATE TABLE `pedidos` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(30) NOT NULL,
  `Endereço` varchar(30) NOT NULL,
  `Lanche` varchar(30) NOT NULL,
  `Bebida` varchar(30) NOT NULL,
  `Pag` varchar(30) NOT NULL,
  `Valor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pedidos`
--

INSERT INTO `pedidos` (`Id`, `Nome`, `Endereço`, `Lanche`, `Bebida`, `Pag`, `Valor`) VALUES
(57, 'joao silva', 'gerelado mendes', 'coxinha', 'coca', 'dinheiro', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
