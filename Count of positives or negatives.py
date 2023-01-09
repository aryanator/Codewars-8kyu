def count_positives_sum_negatives(arr):
    p=0
    q=0
    if arr==[]:
        return []
    else:
        for i in arr:
            if i>0:
                p=p+1
            if i<0:
                q=q+i
        return[p,q]
