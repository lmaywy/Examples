﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Algorithm.Sort
{
    public class QuickSort
    {
        /*
        * 快速排序
        *
        * 参数说明：
        *     a -- 待排序的数组
        *     l -- 数组的左边界(例如，从起始位置开始排序，则l=0)
        *     r -- 数组的右边界(例如，排序截至到数组末尾，则r=a.length-1)
        快速排序稳定性
        快速排序是不稳定的算法，它不满足稳定算法的定义。
        算法稳定性 -- 假设在数列中存在a[i]=a[j]，若在排序之前，a[i]在a[j]前面；并且排序之后，a[i]仍然在a[j]前面。则这个排序算法是稳定的！

        快速排序时间复杂度
        快速排序的时间复杂度在最坏情况下是O(N2)，平均的时间复杂度是O(N*lgN)。
        这句话很好理解：假设被排序的数列中有N个数。遍历一次的时间复杂度是O(N)，需要遍历多少次呢？至少lg(N+1)次，最多N次。
        (01) 为什么最少是lg(N+1)次？快速排序是采用的分治法进行遍历的，我们将它看作一棵二叉树，它需要遍历的次数就是二叉树的深度，而根据完全二叉树的定义，它的深度至少是lg(N+1)。因此，快速排序的遍历次数最少是lg(N+1)次。
        (02) 为什么最多是N次？这个应该非常简单，还是将快速排序看作一棵二叉树，它的深度最大是N。因此，快读排序的遍历次数最多是N次。
        */
        public static void Sort(int[] a, int l, int r)
        {
            if (l < r)
            {
                int i=l, j=r, x=a[i];

                while (i < j)
                {
                    while (i < j && a[j] > x)
                        j--; // 从右向左找第一个小于x的数
                    if (i < j)
                        a[i++] = a[j];
                    while (i < j && a[i] < x)
                        i++; // 从左向右找第一个大于x的数
                    if (i < j)
                        a[j--] = a[i];
                }
                a[i] = x;
                Sort(a, l, i - 1); /* 递归调用 */
                Sort(a, i + 1, r); /* 递归调用 */
            }
        }
    }
}
