   M S B A M L   `   `   `  ����K  GDesktopFront-End, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:DesktopFront_EndDesktopFront_End  5   	        DesktopFront_End.ViewOrder   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:DesktopFront_End     5   	     � Title$  Edit Product��5   
    � WindowStyle$
 None=�6   $	��450��62   $	��350��6?    � WindowStartupLocation$ CenterScreen=�6K   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Make New Order��6!   $��Italic$�67   $��20(�6J   $��20q�6X   �� 5   
   $��1��6   $2��,Select multiple products from the list below��6!   $��13(�6U   $��20,0,0,0q�6c   �� 5   
   -   5        $��productsList��5   ,    �� SelectionMode$ Multiple=�6   $��2��6@   $��20q�6M   6[   �� 5   
   $��Right=�6    �� Orientation$ 
Horizontal=�61   $��3��6J   $��20q�6W   .+�5      �� -   5        $��orderbtn��5      $��Order��6%   $��5q�65   $��10q�6@   $��70��6M   $
��Left=�6X   6s   �� 5      -   5        $��	cancelbtn��5      $��cancel��6&   $��5q�67   $��10q�6B   $��70��6O   $
��Left=�6Z   6u   5      5      5      