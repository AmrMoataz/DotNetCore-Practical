   M S B A M L   `   `   `  ����K  GDesktopFront-End, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:DesktopFront_EndDesktopFront_End  5   	   %    DesktopFront_End.ViewAddProduct   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:DesktopFront_End     5   	     � Title$  Add New Product��5   	    � WindowStyle$
 None=�6!   $	��450��64   $	��350��6A    � WindowStartupLocation$ CenterScreen=�6M   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��Add New Projcet��6   $��Italic$�6+   $��0��6>   $��20(�6K   $��20q�6Y   �� 5   
    �� Orientation$ Vertical=�6   $��1��6,   $��20q�69   .+�5      �� $
��Name��6   $��17(�6$   $��3q�62   �� 5      -   5        $��nametxt��5      $��3q�6%   $
��auto��60   $��5q�6=   5      �� 5   
   $ Vertical=�6   $��2��6,   $��20q�69   .+�5      �� $��Price��6   $��17(�6%   $��3q�63   �� 5      -   5        $��pricetxt��5   C   $��3q�6S   $
��auto��6^   $��5q�6k   5      �� 5   
   $ Vertical=�6   $��3��6,   $��20q�69   .+�5       �� $	��Qty��6   $��17(�6#   $��3q�61   �� 5!      -   5        $��qtytxt��5!   A   $��3q�6O   $
��auto��6Z   $��5q�6g   5"      �� 5$   
   $��Right=�6   $ 
Horizontal=�61   $��4��6J   $��20q�6W   .+�5%      �� -   5        $��addbtn��5%      $	��Add��6#   $��5q�61   $��10q�6<   $��70��6I   $
��Left=�6T   6o   �� 5&      -   5        $��	cancelbtn��5&      $��cancel��6&   $��5q�67   $��10q�6B   $��70��6O   $
��Left=�6Z   6u   5'      5(      5)      