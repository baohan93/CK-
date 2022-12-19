using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
               "VALUES(1,N'Bột sữa,sữa đặc,trân châu trắng',N'Hương vị chân ái đúng gu đậm đà với trà oolong được “sao” (nướng) lâu hơn cho hương vị đậm đà, hòa quyện với sữa thơm béo.',1, 'https://product.hstatic.net/1000075078/product/1647510917_tra-sua-oolong-nuong-tran-chau-da-lifestyle_adc7757d2e8a4629ae3b3c2c8eaf4fc4.jpg','https://product.hstatic.net/1000075078/product/1647510917_tra-sua-oolong-nuong-tran-chau-da-lifestyle_adc7757d2e8a4629ae3b3c2c8eaf4fc4.jpg', 1 ,N'Trà sữa Oolong Nướng Trân Châu', 55.000)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(1,N'Bột sữa,sữa đặc,mắc ca',N'Mỗi ngày sẽ là điều tươi mới hơn với sữa hạt mắc ca thơm ngon, bổ dưỡng quyện cùng nền trà oolong cho vị cân bằng, ngọt dịu.',1,'https://product.hstatic.net/1000075078/product/1645972337_tra-sua-mac-ca-tran-chau-lifestyle_547c86a0d6544fac95681105c55e32a6.jpg','https://product.hstatic.net/1000075078/product/1645972337_tra-sua-mac-ca-tran-chau-lifestyle_547c86a0d6544fac95681105c55e32a6.jpg',0,N'Trà Sữa Mắc Ca Trân Châu', 56.000)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(1,N'Bột sữa,sữa đặc,socola',N'Trong tiết trời se lạnh, còn gì tuyệt hơn khi được nhâm nhi ly Trà Sữa Sô Cô La ấm nóng. Hương vị trà Oolong nướng quen thuộc.',1,'https://product.hstatic.net/1000075078/product/1669707518_s-more-choco_0eea2ddb8ae1484fb055d55344c4e55d.jpg','https://product.hstatic.net/1000075078/product/1669707518_s-more-choco_0eea2ddb8ae1484fb055d55344c4e55d.jpg',0,N'Trà Sữa Sô Cô La (Nóng)', 56.000)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(1,N'Bột sữa,sữa đặc,sữa dừa',N'Trà Sữa Dừa ấm nóng, xua tan lạnh lẽo hệt như cái ôm của người thương. Nền trà Oolong nướng đậm hương, êm dịu.',1,'https://product.hstatic.net/1000075078/product/1669707486_very-berry_ee209363c11d4b3fb57f5af7bcb5546d.jpg','https://product.hstatic.net/1000075078/product/1669707486_very-berry_ee209363c11d4b3fb57f5af7bcb5546d.jpg',0,N'Trà Sữa Dừa (Nóng)', 57.000)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(2,N'Trà Hibiscus,phúc bồn tử,quýt',N'Nền trà Hibiscus thanh mát, quyện vị chua chua ngọt ngọt của phúc bồn tử 100% tự nhiên.',1,'https://product.hstatic.net/1000075078/product/1669707649_bg-hitea-quyt-no_f5ea36d0b12a4016a043f2a83f0b1b74.jpg','https://product.hstatic.net/1000075078/product/1669707649_bg-hitea-quyt-no_f5ea36d0b12a4016a043f2a83f0b1b74.jpg',1,N'Hi Tea Phúc Bồn Tử Mandarin', 49.000)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(2,N'Trà hoa Hibiscus, xoài, topping Aloe Vera',N'Vị ngọt thanh, thơm phức từ xoài chín mọng kết hợp cùng vị chua đặc trưng của trà hoa Hibiscus tự nhiên.',1,'https://product.hstatic.net/1000075078/product/1655199358_xoai-aloe-vera_fe1b78d69f3542cfbc232ddea03de37e.jpg','https://product.hstatic.net/1000075078/product/1655199358_xoai-aloe-vera_fe1b78d69f3542cfbc232ddea03de37e.jpg',1,N'Hi Tea Xoài Aloe Vera', 49.000)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(2,N'Trà hoa Hibiscus, mận muối mặn mặn, dâu tây',N'Sự kết hợp độc đáo giữa 3 sắc thái hương vị khác nhau: trà hoa Hibiscus chua thanh, Mận muối mặn mặn và Dâu tây.',0,'https://product.hstatic.net/1000075078/product/1669737867_dau-man-muoi-aloe-vera_1662820f7267428d8c3526b0c6f55f43.png','https://product.hstatic.net/1000075078/product/1669737867_dau-man-muoi-aloe-vera_1662820f7267428d8c3526b0c6f55f43.png',0,N'Hi Tea Dâu Tây Mận Muối Aloe Vera', 48.000)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(2,N'Trà hoa Hibiscus, đào',N'Sự kết hợp ăn ý giữa Đào cùng trà hoa Hibiscus, tạo nên tổng thể hài hoà dễ gây “thương nhớ” cho team thích món thanh mát, có vị chua nhẹ.',0,'https://product.hstatic.net/1000075078/product/1669737919_hi-tea-dao_c9025a188d3047debf70658904df863e.jpg','https://product.hstatic.net/1000075078/product/1669737919_hi-tea-dao_c9025a188d3047debf70658904df863e.jpg',0,N'Hi Tea Đào', 48.000)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(3,N'Cà phê, kem trứng, bánh sampa',N'Hương vị dễ ghiền được tạo nên bởi chút đắng nhẹ của cà phê, lớp kem trứng béo ngọt dịu hấp dẫn.',1,'https://product.hstatic.net/1000075078/product/1638170137_tiramisu_ce5cd1a769d24baa91302995b02d67a1.jpg','https://product.hstatic.net/1000075078/product/1638170137_tiramisu_ce5cd1a769d24baa91302995b02d67a1.jpg',1,N'Mousse Tiramisu', 35.000)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(3,N'Bột matcha, kem tươi, bột gạo nếp',N'Bao bọc bởi lớp vỏ Mochi dẻo thơm, bên trong là lớp kem lạnh cùng nhân trà xanh đậm vị. Gọi 1 chiếc Mochi cho ngày thật tươi mát.',0,'https://product.hstatic.net/1000075078/product/1655348113_mochi-traxanh_25a31acc21944fe29df36ec00ee49c6b.jpg','https://product.hstatic.net/1000075078/product/1655348113_mochi-traxanh_25a31acc21944fe29df36ec00ee49c6b.jpg',0,N'Mochi Kem Matcha', 19.000)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(3,N'Trứng muối, phô mai, bột custard',N'Croissant trứng muối thơm lừng, bên ngoài vỏ bánh giòn hấp dẫn bên trong trứng muối vị ngon khó cưỡng.',0,'https://product.hstatic.net/1000075078/product/croissant-trung-muoi_880850_bff2e320c18e46c2a47b0c5b1e233f4d.jpg','https://product.hstatic.net/1000075078/product/croissant-trung-muoi_880850_bff2e320c18e46c2a47b0c5b1e233f4d.jpg',0,N'Croissant trứng muối', 35.000)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanche");
        }
    }
}
