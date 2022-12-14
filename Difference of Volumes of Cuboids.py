import numpy 
def find_difference(a, b):

    result1 = numpy.prod(a)
    result2 = numpy.prod(b)
    if result1-result2 > 0:
        return result1-result2
    else:
        return result2-result1

    
