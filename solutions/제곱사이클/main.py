def sqr_seq(alist:list):
    if len(alist) >= 100:
        return alist

    chk = alist[-1]
    nextval = sum(int(s)**2 for s in str(chk)) if len(str(chk)) > 1 else chk**2
    if nextval in alist:
        return alist

    alist.append(nextval)
    return sqr_seq(alist)


if __name__ == '__main__':
    arg = 77
    rst = sqr_seq([arg])
    print(rst)