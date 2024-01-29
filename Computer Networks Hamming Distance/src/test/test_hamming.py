import unittest
from src.hamming_distance import hamming_distance_calculator

class TestHammingMethods(unittest.TestCase):
    def test_len_checker(self):
        result =  hamming_distance_calculator.len_equality_checker("11011", "01010" )
        self.assertTrue(result,True)
