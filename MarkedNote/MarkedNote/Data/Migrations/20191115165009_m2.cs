using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarkedNote.Data.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FriendRequest_AspNetUsers_RecieverRecordId",
                table: "FriendRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_FriendRequest_AspNetUsers_SenderRecordId",
                table: "FriendRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_FriendsList_AspNetUsers_FriendRecordId",
                table: "FriendsList");

            migrationBuilder.DropForeignKey(
                name: "FK_FriendsList_AspNetUsers_MainUserRecordId",
                table: "FriendsList");

            migrationBuilder.DropForeignKey(
                name: "FK_Note_AspNetUsers_AuthorRecordId",
                table: "Note");

            migrationBuilder.DropForeignKey(
                name: "FK_NoteComments_AspNetUsers_AuthorRecordId",
                table: "NoteComments");

            migrationBuilder.DropForeignKey(
                name: "FK_SharedWith_AspNetUsers_RecieverRecordId",
                table: "SharedWith");

            migrationBuilder.DropIndex(
                name: "IX_SharedWith_RecieverRecordId",
                table: "SharedWith");

            migrationBuilder.DropIndex(
                name: "IX_NoteComments_AuthorRecordId",
                table: "NoteComments");

            migrationBuilder.DropIndex(
                name: "IX_Note_AuthorRecordId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_FriendsList_FriendRecordId",
                table: "FriendsList");

            migrationBuilder.DropIndex(
                name: "IX_FriendsList_MainUserRecordId",
                table: "FriendsList");

            migrationBuilder.DropIndex(
                name: "IX_FriendRequest_RecieverRecordId",
                table: "FriendRequest");

            migrationBuilder.DropIndex(
                name: "IX_FriendRequest_SenderRecordId",
                table: "FriendRequest");

            migrationBuilder.DropColumn(
                name: "RecieverRecordId",
                table: "SharedWith");

            migrationBuilder.DropColumn(
                name: "AuthorRecordId",
                table: "NoteComments");

            migrationBuilder.DropColumn(
                name: "AuthorRecordId",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "FriendRecordId",
                table: "FriendsList");

            migrationBuilder.DropColumn(
                name: "MainUserRecordId",
                table: "FriendsList");

            migrationBuilder.DropColumn(
                name: "RecieverRecordId",
                table: "FriendRequest");

            migrationBuilder.DropColumn(
                name: "SenderRecordId",
                table: "FriendRequest");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecieverRecordId",
                table: "SharedWith",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorRecordId",
                table: "NoteComments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorRecordId",
                table: "Note",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FriendRecordId",
                table: "FriendsList",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainUserRecordId",
                table: "FriendsList",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecieverRecordId",
                table: "FriendRequest",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderRecordId",
                table: "FriendRequest",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SharedWith_RecieverRecordId",
                table: "SharedWith",
                column: "RecieverRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_NoteComments_AuthorRecordId",
                table: "NoteComments",
                column: "AuthorRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_AuthorRecordId",
                table: "Note",
                column: "AuthorRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendsList_FriendRecordId",
                table: "FriendsList",
                column: "FriendRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendsList_MainUserRecordId",
                table: "FriendsList",
                column: "MainUserRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendRequest_RecieverRecordId",
                table: "FriendRequest",
                column: "RecieverRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendRequest_SenderRecordId",
                table: "FriendRequest",
                column: "SenderRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_FriendRequest_AspNetUsers_RecieverRecordId",
                table: "FriendRequest",
                column: "RecieverRecordId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FriendRequest_AspNetUsers_SenderRecordId",
                table: "FriendRequest",
                column: "SenderRecordId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FriendsList_AspNetUsers_FriendRecordId",
                table: "FriendsList",
                column: "FriendRecordId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FriendsList_AspNetUsers_MainUserRecordId",
                table: "FriendsList",
                column: "MainUserRecordId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Note_AspNetUsers_AuthorRecordId",
                table: "Note",
                column: "AuthorRecordId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NoteComments_AspNetUsers_AuthorRecordId",
                table: "NoteComments",
                column: "AuthorRecordId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SharedWith_AspNetUsers_RecieverRecordId",
                table: "SharedWith",
                column: "RecieverRecordId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
